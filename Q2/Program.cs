using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Q2找出數值區間內的所有質數
			int startNumber = 203;
			int endNumber = 448;

			Console.WriteLine("203-448之間是質數的有:");

			for (int i = startNumber; i <= endNumber; i++)
			{
				bool isPrime = true;
				for (int k = 2; k <= (int)Math.Sqrt(i); k++)
				{

					//string result = isNotPrime == false ? $"{i}" : string.Empty;
					//Console.WriteLine(result);

					if (i % k == 0)
					{
						isPrime = false;
						break;
					}

				}
					
				if (isPrime)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
