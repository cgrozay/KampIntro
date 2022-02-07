// See https://aka.ms/new-console-template for more information
using OOP1;
Product product1 = new Product();
product1.ProductId = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product { ProductId = 2, CategoryId = 1, ProductName = "Kalem", UnitPrice = 5, UnitsInStock = 5 };

ProductManager productManager= new ProductManager();
productManager.Add(product1);


