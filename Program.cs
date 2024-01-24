using Comparison.Entities;

using System.Security.Cryptography;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>()
            {
                new Product("Tv", 900.00),
                new Product("Notebook", 1000.00),
                new Product("Tablet", 1230.00),
                new Product("Videogame", 1500.00),
                new Product("Toy", 20.00)
            };

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            list.ForEach(product =>
            {
                Console.WriteLine(product);
            });
        }
    }
}
