--7. Перечислите названия товаров, которые были проданы в количестве менее 1000 штук (quantity)?


WITH ProductQuanity AS (SELECT [ProductID], SUM([Quantity]) AS Quantity
	FROM [Northwind].[dbo].[Order Details]
	GROUP BY [ProductID]
	HAVING SUM([Quantity]) < 1000)

SELECT [ProductName]
	FROM [Northwind].[dbo].[Products]
	JOIN [ProductQuanity]
		ON [ProductQuanity].ProductID = [Products].[ProductID]