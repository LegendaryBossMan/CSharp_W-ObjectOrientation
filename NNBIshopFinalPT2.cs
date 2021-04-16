using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNBIshopMidTermPT2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Create a program that:

				1.Allows the user to enter his or her height and weight in inches and pounds.

				2.Converts the height and weight to meters and kilograms.
				1 -0.0254 height 1 - 0.453592 weight   
			3.Calculates the person's BMI: 

			To work out your BMI:
			divide your weight in kilograms(kg) by your height in metres(m)
				then divide the answer by your height again to get your BMI.
			4.If the person's BMI is less than 18.5, display "Low." If the person's BMI is between 18.5 and 24.9, display "normal." If the person's BMI is between 25 and 29.9, display "overweight." And, if the BMI is greater than 30, display "obese."

			Something to consider...could this be done by developing a Human Class that has a BMI method?*/
			double height1;
			double height2;
			double weight1;
			double weight2;
			double convert1 = 0.0254;
			double convert2 = 0.453592;

			Console.WriteLine("BMI Calulator:");
			Console.WriteLine("_________________\n");


			Console.WriteLine("Enter your height in inches:");
			height1 = Convert.ToDouble(Console.ReadLine());
			height2 = height1 * convert1;
			Console.WriteLine("Enter your height in pounds: ");
			weight1 = Convert.ToDouble(Console.ReadLine());
			weight2 = weight1 * convert2;
			double BMI;
			BMI = weight2 / height2;
			Console.WriteLine("Your BMI is: {0}", BMI);
			if (BMI < 18.5)
			{
				Console.WriteLine("Under Weight");
			}
			else if(BMI > 18.5 && BMI < 24.9)
			{
				Console.WriteLine("Normal");
			}
			else if(BMI > 25 && BMI < 29.9)
			{
				Console.WriteLine("Over Weight");
			}
			else if(BMI > 30)
				{
				Console.WriteLine("Obese");
				}
			else
			{
				Console.WriteLine("Well there you are Mr.Purple.");
			}
			//Could add a rope and choke option too, but this will do. (AKA kneck and waist measurement)




				Console.ReadKey();
		}

	}

  /*   could have public  class of Human
	 //Could have method for BMI. This isn't for you Mr.Purple it's for my notes.
*/

}
