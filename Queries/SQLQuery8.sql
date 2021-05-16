--8. Как зовут покупателей, которые делали заказы с доставкой в другой город (не в тот, в котором они прописаны)?


SELECT [ContactName]
	FROM [Northwind].[dbo].[Customers]
	WHERE [City] NOT IN
		(SELECT [ShipCity]
			FROM [Northwind].[dbo].[Orders]
			WHERE [Orders].[CustomerID] = [Customers].[CustomerID])
