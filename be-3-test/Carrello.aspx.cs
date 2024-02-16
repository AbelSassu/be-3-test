﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using be_3_test;

namespace be_3_test
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCartItems();
            }
        }

        private void LoadCartItems()
        {
            List<int> product = (List<int>)Session["ProductID"];
            DataTable dt = new DataTable();
            dt.Columns.Add("Immagine", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Prezzo", typeof(double));

            if (product != null)
            {
                foreach (int id in product)
                {
                    try
                    {
                        DBConn.conn.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT * FROM Products WHERE ID='{id}'", DBConn.conn);
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            dt.Rows.Add(dataReader["Immagine"], dataReader["ID"], dataReader["Nome"], dataReader["Prezzo"]);
                        }
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
            else 
            {
                lblEmptyCart.Text = "<h3>Il carrello è vuoto</h3>";
            }

            rptCartItems.DataSource = dt;
            rptCartItems.DataBind();

            double totCart = GetTotalCartAmount(product);
            contentTot.InnerHtml = $"<h2>Totale: {totCart}€</h2>";
        }

        private double GetTotalCartAmount(List<int> productIds)
        {
            double totalAmount = 0;

            if (productIds != null)
            {
                foreach (int id in productIds)
                {
                    try
                    {
                        DBConn.conn.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT Prezzo FROM Products WHERE ID='{id}'", DBConn.conn);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            totalAmount += Convert.ToDouble(result);
                        }
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

            return totalAmount;
        }

        protected void rptCartItems_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int productId = Convert.ToInt32(e.CommandArgument);
                List<int> product = (List<int>)Session["ProductID"];

                if (product != null)
                {
                    product.Remove(productId);
                    Session["ProductID"] = product;
                    LoadCartItems();
                }
            }
        }
    }
}