using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		int remainder = 0;
		int newNum = 0;
		
		while (num != 0) {
			remainder = num % 10;
			newNum = newNum * 10 + remainder;
			num = num / 10;
		}
		Console.WriteLine(newNum);
	}
}
