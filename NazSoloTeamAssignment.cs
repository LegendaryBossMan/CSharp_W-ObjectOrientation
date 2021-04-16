using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NazSoloTeamAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			// array of random 2 numbers check
			//user must input what the 2 numbers added are equal to
			//display how many are wrong and how many where right
			// asks if they would like todo it again

			//figure this out later
			//it's later

			int right = 0;
			int wrong = 0;
			Random rnd = new Random();
			int end = 0;
			while (end != 1)
			{
				for (int i = 1; i <= 10; i++)
				{
					int[] array1 = { rnd.Next(1, 10), rnd.Next(1, 10) };
					int sum1 = array1.Sum();
				int answer = 0;
					Console.WriteLine("Numbers are: {0},{1}", array1[0], array1[1]);
					Console.WriteLine("What is the sum?");
					answer = Convert.ToInt32(Console.ReadLine());
					// Show Results results to screen.
					//Console.WriteLine(sum1);
					if (answer != sum1)
					{
						wrong++;
					}
					if (answer == sum1)
					{
						right++;
					}

				}
				Console.WriteLine("Number Correct: {0}", right);
				Console.WriteLine("Number Wrong: {0}", wrong);
				Console.WriteLine("Would you like todo it again?(Press 1 to end, 0 to go again)");
				end = Convert.ToInt32(Console.ReadLine());
			}


			Console.ReadKey();
		}//end main
	}//end class
}//end namepace
