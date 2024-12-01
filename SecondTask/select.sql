SELECT p.title AS ProductTitle, c.title AS CategoryTitle
FROM Products AS p
LEFT JOIN ProductCategories AS pc ON p.id = pc.productId 
LEFT JOIN Categories AS c ON pc.categoryId = c.id;