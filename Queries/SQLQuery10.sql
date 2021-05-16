--10. Сколько всего единиц товаров (то есть, штук – Quantity) продал каждый продавец (имя, фамилия) осенью 1996 года?

SELECT [LastName], [FirstName], SUM([Quantity])
	FROM [Northwind].[dbo].[Employees]
	INNER JOIN [Northwind].[dbo].[Orders]
		ON [Employees].[EmployeeID] = [Orders].[EmployeeID]
	INNER JOIN [Northwind].[dbo].[Order Details]
		ON [Order Details].[OrderID] = [Orders].[OrderID]
	WHERE YEAR([OrderDate]) = (1996)
		AND MONTH([OrderDate]) BETWEEN (9) AND (12)
	GROUP BY [Employees].[EmployeeID], [LastName], [FirstName]