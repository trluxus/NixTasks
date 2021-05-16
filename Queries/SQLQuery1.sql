SELECT [ProductName], [UnitPrice]
	FROM [Northwind].[dbo].[Products]
		INNER JOIN [Northwind].[dbo].[Categories] 
			ON ([Categories].[CategoryID] = [Products].[CategoryID])
	WHERE [Categories].[CategoryID] = 1 
		AND [UnitPrice] = (SELECT MAX([UnitPrice]) FROM [Northwind].[dbo].[Products])
	