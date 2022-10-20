using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q3 有一個數值, 是四位數
			//左邊二位的數字相同
			//右邊二位的數字相同
			//這個四位數值, 剛好也是某整數的平方
			//請問這個四位數值是什麼?

			for (int i = 1; i < 10; i++)
			{
				for (int k = 1; k < 10; k++)
				{
					int number = i * 1100 + k * 11;
					double sqrt = Math.Sqrt(number);
					if (sqrt == Math.Floor(sqrt))
					{
						Console.WriteLine(number);
					}
				}
			}
		}
	}
}
