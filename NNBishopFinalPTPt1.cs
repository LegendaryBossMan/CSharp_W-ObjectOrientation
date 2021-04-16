using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNBishopMidTermPt1
{
	class Program
	{

		static void Main(string[] args)
		{

		/*	Create a program in C# that:

			1.Allows the user to fill two different arrays with 4 numbers each.

			2.Adds, Subtracts, Multiplies the corresponding elements of the two arrays.

			3.Displays the results.

		PARTIAL Sample Output:
					Array1: [1, 3, -5, 4]
					Array2: [1, 4, -5, -2]
					Multiply corresponding elements of two arrays:
					1 12 25 - 8*/
			int[] array1;
			int[] array2;
			int[] array3;
			array1 = new int[3];
			array2 = new int[3];
			array3 = new int[3];
			Console.WriteLine("Array Calculator:");
			Console.WriteLine("___________________\n");
			Console.WriteLine("Please Enter 4 integer numbers with no spaces: ");
			for (int i = 0; i < 4; i++)
			{
				array1[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Please Enter 4 integer numbers again: ");
			for (int j = 0; j < 4; j++)
			{
				array2[j] = int.Parse(Console.ReadLine());
			}



				//sum
			for (int i = 0; i < 4; i++)
			{

					array3[i] = array1[i] + array2[i];
				Console.WriteLine("The sum of the two sets of numbers is: {0}", array3);
			}
			//sub
			for (int i = 0; i < 4; i++)
			{

				array3[i] = array1[i] - array2[i];
				Console.WriteLine("The difference in the two sets of numbers is: {0}", array3);

			}
			//mult
			for (int i = 0; i < 4; i++)
			{

				array3[i] = array1[i] * array2[i];
				Console.WriteLine("The  of the two sets of numbers is: {0}", array3);
			}
			Console.ReadKey();
		}
	}
}
