# TestExercise
# В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите   # SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

select ProductName, CategoryName from Product
left join ProductCategory on Product.IDProduct=ProductCategory.IDProduct 
left join Category on ProductCategory.IDCategory=Category.IDCategory
order by ProductName
