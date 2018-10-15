using System;

namespace Lab2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository prodsrep = new ProductRepository();
            Product prod = prodsrep.GetProductByPosition(1);
            Console.WriteLine(prod);
            Console.ReadKey();
        }
    }
}
