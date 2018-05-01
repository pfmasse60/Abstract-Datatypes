using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a Number: ");
		
		string strNum = Console.ReadLine();
		
		int n = Convert.ToInt32(strNum);
		
		for (int i =0; i<= n; i++){
			Console.WriteLine(Fibonacci(i));	
		}
		
	}
	
	private static int Fibonacci(int n)
	{
			if (n == 0)
				return 0;
			if (n == 1)
				return 1;
		
			return Fibonacci(n-1) + Fibonacci(n-2);
		
	}
}
