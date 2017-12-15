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
            //Pilha (Ultimo a Entrar, Primeiro a Sair)
            Stack pilha = new Stack();

            pilha.Push("Prato 1");//Inserir na pilha
            pilha.Push("Prato 2");
            pilha.Push("Prato 3");
            pilha.Push("Prato 4");
            pilha.Push("Prato 5");

            while(pilha.Count > 0)
            {
                var prata = pilha.Pop();//Desempilhar
                var prata2 = pilha.Peek();//Verifica o item no topo da pilha
            }



            Console.ReadLine();
        }

       

        
    }
}
