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
           string retorno =  RetornarString("joao");
           Console.WriteLine(retorno);
           Console.ReadLine();
                  
        }

        //Metódo com Retorno
        public static string RetornarString(string nome)
        {
            return nome;
        }

        //Método sem Retorno
        public static void ExibirMensagem()
        {
            Console.WriteLine("Mensagem Exibida");
        }
    }
}
