--5. How many French cities did seller #1 serve in 1997?

SELECT [ShipCountry], COUNT(DISTINCT [ShipCity]) AS NumberOfCities
	FROM [Northwind].[dbo].[Orders]
	WHERE [EmployeeID] = 1
	GROUP BY [ShipCountry]
	HAVING [ShipCountry] LIKE 'France'