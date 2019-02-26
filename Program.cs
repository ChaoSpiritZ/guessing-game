using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260219
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rngsus = new Random();

			int s = rngsus.Next(100) + 1;
			Console.WriteLine("Guess the number");
			int x = Convert.ToInt32(Console.ReadLine());
			int g = 1;
			while (x != s)
			{
				if (x > s)
				{
					Console.WriteLine("too big");
					g++;
					x = Convert.ToInt32(Console.ReadLine());
				}
				else
				{
					Console.WriteLine("too small");
					g++;
					x = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine($"{x} is correct!");
			Console.WriteLine($"it took you {g} guesses");
		}
	}
}
