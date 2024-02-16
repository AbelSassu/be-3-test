CREATE TABLE Products ( ID INT IDENTITY(1,1) PRIMARY KEY, Nome NVARCHAR(255), Descrizione NVARCHAR(255), Prezzo DECIMAL(10, 2), Immagine Text);

USE [Ecommerce]
GO

INSERT INTO [dbo].[Products]
           ([Nome]
           ,[Descrizione]
           ,[Immagine]
           ,[Prezzo])
     VALUES
           ('Maglietta Blu', 'Una maglietta di cotone blu con maniche corte', 'https://www.csipoint.it/7527-medium_default/t-shirt-bc-blu-royal.jpg', 19.99),
           ('Jeans Skinny Nero', 'Jeans neri con taglio aderente', 'https://data.mascheronistore.it/imgprodotto/jeans-skinny-high-rise-donna-nero_62750_zoom.jpg', 39.99),
           ('Scarpe da Ginnastica Bianche', 'Scarpe da ginnastica bianche con suola in gomma', 'https://i.ebayimg.com/00/s/ODAwWDgwMA==/z/bVYAAOSwJ5ti7dBv/$_12.JPG?set_id=880000500F', 29.99),
           ('Cappotto Invernale Grigio', 'Cappotto grigio imbottito per l''inverno', 'https://i.ebayimg.com/images/g/6P8AAOSw3mVhs9Ty/s-l1600.jpg', 89.99),
           ('Borsa a Tracolla Nera', 'Borsa a tracolla nera in pelle sintetica', 'https://www.maestripellettieri.it/image/cache/catalog/borse-donna/8345N-borsa-donna-a-tracolla-pelle-nera-0-1200x1200.jpg', 49.99),
           ('Orologio da Polso Argento', 'Orologio da polso con cinturino argentato', 'https://m.media-amazon.com/images/I/71JAMziTNwL._AC_UY900_.jpg', 79.99),
           ('Tuta Sportiva Blu', 'Tuta sportiva blu con pantaloni e giacca abbinati', 'https://img.kwcdn.com/product/Fancyalgo/VirtualModelMatting/37fd4de5eedf1274d2246a77960e120e.jpg?imageMogr2/auto-orient%7CimageView2/2/w/800/q/70/format/webp', 59.99),
           ('Camicia a Righe Bianche e Blu', 'Camicia a righe bianche e blu con colletto button-down', 'https://egress.storeden.net/jpg/6577434400f220a9528b47c0', 29.99),
           ('Felpa con Cappuccio Grigia', 'Felpa con cappuccio grigia in misto cotone', 'https://www.gutteridge.com/dw/image/v2/BDJZ_PRD/on/demandware.static/-/Sites-catalog-gutteridge-master/default/dwd24d8e85/hi-res/FE15253UOGU_0150C_001.jpg?sw=1000&sh=1350&q=90&strip=false', 34.99),
           ('Pantaloni Chino Beige', 'Pantaloni chino beige in cotone', 'https://static.kiabi.it/images/pantaloni-chino-in-twill-di-cotone-beige-ys928_1_frb1.jpg', 44.99),
           ('Giacca di Pelle Nera', 'Giacca di pelle nera con zip', 'https://www.bolf.co.it/ita_pl_Giacca-in-pelle-con-cappuccio-da-uomo-nera-biker-Bolf-11Z8012-89716_13.jpg', 119.99),
           ('Gonna a Pieghe Blu', 'Gonna a pieghe blu in tessuto leggero', 'https://m.media-amazon.com/images/I/51SyKbOIU2S._AC_UY1000_.jpg', 24.99),
           ('Portafoglio in Pelle Marrone', 'Portafoglio da uomo in pelle marrone', 'https://tannerie.it/static/media/uploads/product/.thumbnails/26.19.jpg/26.19-1000x1000.jpg', 19.99),
           ('Cappello di Lana Grigio', 'Cappello di lana grigio con risvolto', 'https://www.cappelleria.it/pic/FASHION-berretto-cuffia-con-risvolto-in-lana-maglia-con-lurex.47472a.jpg', 14.99),
           ('Ombrello Nero', 'Ombrello pieghevole nero con manico in plastica', 'https://m.media-amazon.com/images/I/51i9SNyOsdL._AC_UF894,1000_QL80_.jpg', 9.99);
GO



