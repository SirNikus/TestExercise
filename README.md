# TestExercise
``` sql
select ProductName, CategoryName from Product
left join ProductCategory on Product.IDProduct=ProductCategory.IDProduct 
left join Category on ProductCategory.IDCategory=Category.IDCategory
order by ProductName
```
