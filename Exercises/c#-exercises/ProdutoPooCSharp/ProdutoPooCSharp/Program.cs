using System;

namespace ProdutoPooCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoWithProperty p = new ProdutoWithProperty("TV", 500.00, 10);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}
