using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced02G03
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List <Product> SearchProducts(List<Product> products , Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        public static void PrintProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }
        public static void PrintProducts(List<Product> products, Action<Product> action)
        {
            foreach (var product in products)
            {
                action(product);
            }
        }
    }
}
