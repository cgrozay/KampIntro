﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            
            Console.WriteLine("Ürün Eklendi :"+product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi :"+product.ProductName);
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}
