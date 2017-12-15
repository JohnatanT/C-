using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Método Prinicpal da Classe
        static void Main(string[] args)
        {
            decimal numero = 100.33M;
            string texto = "Texto";
            ImprimirValor(ref numero, texto);
            Console.ReadLine();
        }

        public static void ImprimirValor(ref decimal valor, string mensagem)
        {
            Console.WriteLine(valor);
        }

        
    }
}
