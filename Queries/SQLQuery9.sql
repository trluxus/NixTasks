--9. Товарами из какой категории в 1997-м году заинтересовалось больше всего компаний, имеющих факс?


WITH ProductAmount AS(SELECT [ProductID], SUM([Quantity]) AS TotalAmount
	FROM [Northwind].[dbo].[Orders]
	INNER JOIN [Northwind].[dbo].[Order Details]
		ON [Orders].[OrderID] = [Order Details].[OrderID]
	WHERE YEAR([OrderDate]) = (1997)
		AND [CustomerID] IN
		(SELECT [CustomerID]
			FROM [Northwind].[dbo].[Customers]
			WHERE [Fax] IS NOT NULL)
	GROUP BY [ProductID])

SELECT [CategoryName]
	FROM [Northwind].[dbo].[Categories]
	WHERE [CategoryID] = 
		(SELECT TOP 1 [CategoryID]
			FROM [ProductAmount]
			INNER JOIN [Northwind].[dbo].[Products]
				ON [ProductAmount].[ProductID] = [Products].[ProductID]
			GROUP BY [CategoryID]
			ORDER BY SUM([TotalAmount]))
