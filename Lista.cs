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
            //Listas (Não insere em uma ordem, mas na posição que eu declarar)
            ArrayList lista = new ArrayList();

            //Insere na lista
            lista.Insert(0, "Item 1");
            lista.Insert(1, "Item 2");
            lista.Insert(2, "Item 3");

            lista.RemoveAt(2);//Remove um item da Lista

            for (int i = 0; i < lista.Count; i++)
            {
                var item = lista[i];
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

       

        
    }
}
