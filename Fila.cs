using System;
using System.Collections;//Para poder utilizar as filas
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

            //Fila (Primeiro a Entra, Primeiro a Sair)
            Queue fila = new Queue();

            fila.Enqueue("Maria");//Adiciona na Fila
            fila.Enqueue("Joao");

            while(fila.Count > 0)
            {
                var nome = fila.Dequeue();//Desenfileira
                var atual = fila.Peek();//Olha o primeiro a fila
            }



            

            Console.ReadLine();
        }

       

        
    }
}
