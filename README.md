# Ответ на второй вопрос

``` sql
SELECT p.ProductName, ISNULL(c.CategoryName, 'Без категории') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
```
