using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pessoa
    {
        //Atributos
        private string nome;
        private string sobreNome;
        private DateTime dataNascimento;
        private char sexo;

        //Gets e Sets
        public string Nome {
            set { nome = value; }
            get { return nome; }
        }

        public string SobreNome {
            set { sobreNome = value; }
            get { return sobreNome; }
        }

        public DateTime DataNascimento{
            set { dataNascimento = value; }
            get { return dataNascimento; }
        }

        public char Sexo {
            set { sexo = value; }
            get { return sexo; }
        }


        //Construtor
        public Pessoa()
        {
                
        }

        //Metodo de Falar
        public void Falar()
        {
            Console.Write(string.Format("{0} {1} {2} {3}", nome, sobreNome, sexo, dataNascimento));
        }
            

    }
}