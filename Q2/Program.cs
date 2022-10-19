﻿using System;
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
			int number= 203;
			int endNumber = 448;

			Console.WriteLine("203-448之間是質數的有:");
			
			for (int i = number; i <= endNumber; i++)
			{
				for (int k = 2; k <= (int)Math.Sqrt(i); k++)
				{
					bool isNotPrime = (number % k == 0);
					if (isNotPrime == false)
					{
						Console.WriteLine(i);
						break;
					}
					else
					{
						Console.WriteLine();
					}
				}
			}
		}
	}
}
