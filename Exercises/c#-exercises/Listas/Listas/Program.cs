using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Paulo");
            list.Add("Carlos");
            list.Add("Camilo");
            list.Add("Elaine");
            list.Add("Vilma");
            list.Insert(2, "Marcos");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine();
            string s1 = list.Find(x => x[0] == 'C');
            Console.WriteLine("Primeiro A: " + s1);
            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Ultimo A: " + s2);
            Console.WriteLine();
            int pos1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("Primeiro posicao comecando com C: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Primeiro posicao comecando com C: " + pos2);
            Console.WriteLine();

            List<string> list2  = list.FindAll(x => x.Length == 5);

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");
            list.RemoveAt(1);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");
            list.Remove("Camilo");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");
            list.RemoveAll(x => x[0] == 'C');

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            list.RemoveRange(2, 2);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
