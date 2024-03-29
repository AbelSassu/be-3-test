﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace be_3_test
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DBConn.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", DBConn.conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                string content = "";

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        content += $@" <div class=""card col-6 col-md-4 col-lg-3 ms-4 mb-3"">
                        <img class=""card-img-top h-100 w-100"" alt=""{dataReader["Nome"]}"" src=""{dataReader["Immagine"]}""/>
                        <div class=""card-body"">
                        <h5 class=""card-title"">{dataReader["Nome"]}</h5>
                        <p class=""card-text"">{dataReader["Descrizione"]}</p>
                        
                        </div>
                        <div class=""card-footer d-flex align-items-baseline justify-content-around"">
                        <p class=""card-text d-flex"">{dataReader["Prezzo"]}€</p>
                        <a href=""Dettaglio.aspx?product={dataReader["ID"]}"" class=""btn btn-primary"">Dettagli</a>
                        </div>
                        </div>";
                        
                    }
                    dataReader.Close();

                }
                contentHtml.InnerHtml = content;
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if (DBConn.conn.State == ConnectionState.Open)
                {
                    DBConn.conn.Close();
                }
            }
        }
    }
}