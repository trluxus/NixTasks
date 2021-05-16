SELECT DISTINCT [ContactName]
	FROM [Northwind].[dbo].[Customers]
		RIGHT JOIN [Northwind].[dbo].[Orders]
			ON [Customers].[CustomerID] = [Orders].[CustomerID]
	WHERE [ShippedDate] IS NULL