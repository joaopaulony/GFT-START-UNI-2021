using System;
					
public class Program
{
	public static void Main()
	{
		int inicio,final,cubo = 0;
		
		Console.WriteLine("Digite o intervalo inicial: ");
		inicio = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite o intervalo final: ");
		final = Convert.ToInt32(Console.ReadLine());
		
		if (inicio <= final){
			for (int i = inicio; i <= final; i++)
			{
				cubo = inicio;
				cubo = (inicio*inicio*inicio);
				Console.WriteLine("Cubo de {0}:{1}", inicio,cubo);
				inicio++;
			} 
		}
	}
}