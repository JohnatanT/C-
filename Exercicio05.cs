using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colecao = new int[] { 1, 2, 3, 10, 50 };

            foreach (var item in colecao)
            {
                Console.WriteLine(item);
            }

             int tamanho = 10;

           
            Console.ReadLine();//Deixa o Console Aberto
        }
    }
}
