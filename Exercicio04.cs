using System;
					
public class Progam{
	
	public static void Main(){
		double valorDaNotaFiscal = 2900;
		decimal taxa = 0;

		if(valorDaNotaFiscal < 999){
			taxa = 0.2M;
		}else if(valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2900){
			taxa = 0.25M;
		}else if(valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6900){
			taxa = 0.28M;
		}else if(valorDaNotaFiscal >= 7000){
			taxa = 0.3M;
		} 

		Console.Write(taxa);
		
		
		
	}
	
}