using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Introduza um número inteiro:");
        int num = int.Parse(Console.ReadLine());

        if ((num % 3) == 0 && (num % 6) == 0 && (num % 7) == 0)
        {
            Console.WriteLine("Divisivel por 3,6,7");
        }
        else if ((num % 3) == 0 && (num % 6) == 0)
        {
        	Console.WriteLine("Divisivel por 3,6");        
        }else if ((num % 3) == 0 && (num % 7) == 0)
        {
        	Console.WriteLine("Divisivel por 3,7");        
        }else if ((num % 7) == 0 && (num % 6) == 0)
        {
        	Console.WriteLine("Divisivel por 6,7");        
        }else if ((num % 3) == 0)
        {
        	Console.WriteLine("Divisivel por 3");        
        }else if ((num % 6) == 0)
        {
        	Console.WriteLine("Divisivel por 6");        
        }else if ((num % 7) == 0)
        {
        	Console.WriteLine("Divisivel por 7");        
        }
	}
}