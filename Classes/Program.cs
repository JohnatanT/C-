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

            Pessoa p = new Pessoa();
 
            p.Nome = "Johnatan";
            p.SobreNome = "Tavares";
            p.Sexo = 'M';
            p.DataNascimento = DateTime.Now;

            p.Falar();

            Console.ReadLine();
        }

       

        
    }
}
