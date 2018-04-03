using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFVP_Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RetrieveDetails(1);
            AddProducts();


            Console.ReadLine();
        }


        public static void RetrieveDetails(int id)
        {
            
                contextDB context = new contextDB();
                var result = from product in context.products
                             where product.ProductId == id
                             select product;

                foreach (var p in result)
                {
                    Console.WriteLine(p.ProductId + " " + p.ProductName + " " + p.Created);
                }
            

        }


        public static void AddProducts()
        {
            contextDB con = new contextDB();
            product p = new product() { ProductId = 3, ProductName = "product3" };
            con.products.Add(p);
            con.SaveChanges();
            Console.WriteLine("product added");
        }
    }
}
