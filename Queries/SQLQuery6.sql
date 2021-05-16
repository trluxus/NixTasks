--6. В каких странах есть города, в которые было отправлено больше двух заказов?


WITH CityOrders AS (SELECT [ShipCity], COUNT(*) AS NumberOfOrders
	FROM [Northwind].[dbo].[Orders]
	GROUP BY [ShipCity]
	HAVING COUNT(*) > 2)

SELECT DISTINCT[ShipCountry]
	FROM [Northwind].[dbo].[Orders]
	JOIN [CityOrders]
		ON [CityOrders].ShipCity = [Orders].[ShipCity]
