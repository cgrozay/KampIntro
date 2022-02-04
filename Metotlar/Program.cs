// See https://aka.ms/new-console-template for more information

using Metotlar;

Product product1 = new Product();
product1.ProductId = 1;
product1.ProductName = "Elma";
product1.UnitPrice = 2.5;
product1.Description = "Amasya Elmas";

Product product2 = new Product();
product2.ProductId = 2;
product2.ProductName = "Armut";
product2.UnitPrice = 4.5;
product2.Description = "Kelmahmut";

Product product3 = new Product();
product3.ProductId = 3;
product3.ProductName = "Karpuz";
product3.UnitPrice = 6.5;
product3.Description = "Suşehri Karpuzu";

Product[] products = { product1, product2, product3 };
foreach (var product in products)
{
    Console.WriteLine(product.ProductId);
    Console.WriteLine(product.ProductName);
    Console.WriteLine(product.UnitPrice);
    Console.WriteLine(product.Description);
    Console.WriteLine("-----------------");

}

Console.WriteLine("------Metotlar------");

CartManager cartManager=new CartManager();
cartManager.Add(product1);
cartManager.Add(product2);
cartManager.Add(product3);

