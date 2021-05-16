SELECT DISTINCT [ShipCity]
	FROM [Northwind].[dbo].[Orders]
	WHERE [ShippedDate] - [OrderDate] > 10