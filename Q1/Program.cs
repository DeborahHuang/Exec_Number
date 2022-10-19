using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1判斷某數值是不是質數

			int number1= 113;
			double Sqrt = Math.Sqrt(number1);

			for (int i = 2; i < (int)Sqrt; i++)
			{ 
				if (number1 % i == 0)
				{
					Console.WriteLine($"{number1}不是質數");
					break;
				}
				else
				{
					Console.WriteLine($"{number1}是質數");
					break;
				}
			}
		}
	}
}
