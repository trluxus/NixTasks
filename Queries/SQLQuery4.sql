SELECT TOP 1 COUNT(DISTINCT [CustomerID]) AS NumberOfCustomers
	FROM [Northwind].[dbo].[Orders]
	GROUP BY [EmployeeID]
	ORDER BY COUNT([OrderID]) DESC
