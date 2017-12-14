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

            int idade = 1;
            while (idade < 17)
            {
                Console.WriteLine("Menor de Idade");
                idade++;
            }

            Console.ReadLine();//Deixa o Console Aberto
        }
    }
}
