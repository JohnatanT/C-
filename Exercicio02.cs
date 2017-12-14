using System;
public class Exercicio02{
	public static void Main(){
		string nome = "Johnatan";
		string cargo = "Web Developer";
		float salario = 700;

		Console.Write(string.Format("{0} {1}", nome, cargo) + " Ganhando: " + salario);
	}
}