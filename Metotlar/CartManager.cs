using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class CartManager
    {
        public void Add(Product product)
        {
           
            Console.WriteLine("Sepete Eklendi :" + product.ProductName);
            
        }

        public void Add2(Product product)
        {

        }
    }
}
