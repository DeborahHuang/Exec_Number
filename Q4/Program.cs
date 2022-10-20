using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q4百元買百雞 想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元



			for (int cock = 1; cock <= 100; cock++)
			{
				for (int hen = 1; hen <= 100; hen++)
				{
					for (int chicken = 1; chicken <= 100; chicken++)
					{
						int totalNumber = cock + hen + chicken;
						double totalPrice = cock * 5 + hen * 3 + (double)chicken / 3;
						if (totalPrice == 100 && totalNumber == 100)
						{
							Console.WriteLine($"公雞{cock}隻,母雞{hen}隻,小雞{chicken}隻,");
						}
					}
				}
			}
		}
	}
}
