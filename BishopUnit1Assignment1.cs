using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BishopAssignmentDay1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1;
			int number2;
			int number3;
			Console.WriteLine("Small Calculator");
			Console.WriteLine("___________________________");
			Console.WriteLine("Enter a number: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter another number: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter a third number: ");
			number3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("___________________________");
			int sum;
			sum = number1 + number2 + number3;//Addition
			Console.WriteLine("The Sum is: {0}", sum);
			Console.WriteLine("___________________________");
			int average;
			//enter average stuff
			average = sum / 3;
			Console.WriteLine("The Average is: {0}", average);
			Console.WriteLine("___________________________");
			int smallest;
			int largest;
			largest = Math.Max(Math.Max(number1, number2), number3);
			
			smallest = Math.Min(Math.Min(number1, number2), number3);
			Console.WriteLine("The Largest number is: {0}", largest);
			Console.WriteLine("___________________________");
			Console.WriteLine("The Smallest Number is: {0}", smallest);
			
			//Are you ready for the trolling Mr.Sullivan?

			//Display Section
			Console.WriteLine("*********      ***       *        *");
			Console.WriteLine("*       *    *     *    ***      * *");
			Console.WriteLine("*       *   *       *  *****    *   *");
			Console.WriteLine("*       *   *       *    *     *     *");
			Console.WriteLine("*       *   *       *    *    *       *");
			Console.WriteLine("*       *   *       *    *     *     *");
			Console.WriteLine("*       *   *       *    *      *   *");
			Console.WriteLine("*       *    *     *     *       * *");
			Console.WriteLine("*********      ***       *        *");

			
				Console.WriteLine(".......................................................................................... .........");
			Console.WriteLine(".......................................................................................... .........");
			Console.WriteLine(".................................mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm............. .........");
			Console.WriteLine(".........................mmmmmmmmmmmmmmmm..................................mmmmm.......... .........");
			Console.WriteLine("...................mmmmmmmmmmm..........mmmmm...............mm................mmm......... .........");
			Console.WriteLine(".................mmmm............................................mm.............mmm....... .........");
			Console.WriteLine("..............mmmm....m..mmmmmm............mmm..............mm......m............mmm...... .........");
			Console.WriteLine("............mmmm.................................................mm....m..........mmm..... .........");
			Console.WriteLine("...........mmm............mmmmm....................m..........mmm...m....m.........mmm.... .........");
			Console.WriteLine("..........mm...........m.........................m................mm...m....m.......mmm... .........");
			Console.WriteLine("..........mm.........m............m..................................m..m....m.......mm... .........");
			Console.WriteLine("..........mm........m..................................................m..m...........mm.. .........");
			Console.WriteLine(".........mm..........................................mmmmmmmmmmmmmm...................mmm. .........");
			Console.WriteLine("........mmm............mmmmmmmm...................mmmmm...mmmmmmmmmmmm.................mmm.........");
			Console.WriteLine("....mmmm...........mmmmmmmmmmmmmm.............mmmm......mmmmmmmm..mmm..................mmm.......");
			Console.WriteLine("...mmm...mmmmm.mmm.mmmmmmmmmmmmmmm...........mmm.....mmmmmmmmmmmmmmmmm....m....mmmmmmmm.mm mm.....");
			Console.WriteLine("..mm...m..................mmmmmmmmmmmmm.......mmmmmmmmm...........mm...m..................mmm....");
			Console.WriteLine(".mm..m...mm.....................mmmm...........mmmmm......mmm..............mmmmmmmmmm..... ..mm...");
			Console.WriteLine(".mm.m..m...mmmmmm................mm.........................mmmm.......mmmmmm......mmmm... .m.mm..");
			Console.WriteLine(".mmm.....mmmmmmmmmm....m.........mm...........................mmmmmmmmmmm.....mm.....mmm.. .m..mmm");
			Console.WriteLine(".mmm.....m.......mmmmmmmm........mm...........................................mm......mm.. .m..mmm");
			Console.WriteLine(".mmm..m.......mm..mmmm........mmmm.........................................mmmmm.......mm. .m...mm");
			Console.WriteLine(".mm....m......mm...........mmmm................mmmmmmmm................mmmmm...mmmmmm..mm. .m...mm");
			Console.WriteLine(".mmmm...mm..mmmm..........mmmmm....................mm..............mmmmmm.....mmm.mmm.mmm. .m..mmm");
			Console.WriteLine("..mm.mm.....mmmm.......mm..mmmmm.........mmmmmmm...mm..........mmmmmmm........mm......mm.. ....mmm");
			Console.WriteLine("..mmm....m..mm.mmm...m........mmm..............m.mmm......mmmmmmmm.mm.......mmmm.....mm...m..mmm.");
			Console.WriteLine("...mmm.....mmmmmmmmm............mmmmmm...............mmmmmmmm......mm....mmmmmm.........mm..mm...");
			Console.WriteLine("....mmm....mm.mm.mmmmmm...........mmm...........mmmmmmmm..........mmm.mmmmmmmm.......m.... .mmm...");
			Console.WriteLine(".....mm....mmmm..mm..mmmmmmmm........mmmmmmmmmmmmmm..mm..........mmmmmmm..mmm..........mmm mm.....");
			Console.WriteLine(".....mm....mmmm..mm....mmmmmmmmmmmmmmmmmmmm..........mm......mmmmmmmm....mmm............mm m......");
			Console.WriteLine(".....mm....mmmm..mm...mmm.......mm.......mm..........mmm.mmmmmmmmm.mm...mmm...........mmm. .......");
			Console.WriteLine(".....mm....mmmmmmmm...mm........mm.......mm.........mmmmmmmmmmm....mm..mmm...........mmm.. .......");
			Console.WriteLine(".....mm....mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm.......mmmmmm............mm... .......");
			Console.WriteLine(".....mm....mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm.mm...........mmm.............mmm... .......");
			Console.WriteLine(".....mm.....mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm.......mm.........mmm..............mmm.... .......");
			Console.WriteLine(".....mm.....mm.mmmmmmmmmmmmmmmmmmmmmmmmmmm.mm..........mmm.....mmmm...............mmm..... .......");
			Console.WriteLine(".....mm......mm.mm..mm...mm.....mmm........mm...........mm...mmmm...............mmm....... .......");
			Console.WriteLine(".....mm......mmmmmm.mmm...mm.....mm........mm............mmmmmm................mmm........ .......");
			Console.WriteLine(".....mm.......mmmm...mmm..mmm....mm........mm.........mmmmmm.......m.....m...mmm.......... .......");
			Console.WriteLine(".....mm.........mmmmmmmmm..mm....mmm.......mm..mmmmmmmmm........m.....mm...mmmm........... .......");
			Console.WriteLine(".....mm..............mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm.........mm....mm....mmmm...............");
			Console.WriteLine("....mmm........m..........................................m.....mm....mmmmm.. ..............");
			Console.WriteLine("....mm..........m....................................mm......m.....mmmmm..... ..............");
			Console.WriteLine("....mm............m..............................mm......mm.....mmmmm........ ..............");
			Console.WriteLine("..mm.....mm........mmm...........mmmmmmmmmm......mm.......mmmmmm....... ............");
			Console.WriteLine(".mm.........m.........................mmm............mmmmm...... ........");
			Console.WriteLine(".mmm..........mmmmmmmmmmmmmmm.....................mmmmm...... ....");
			Console.WriteLine(".mmm..........................................mmmmm...... ..");
			Console.WriteLine("..mmm...................................mm.mmmmm.......");
			Console.WriteLine("...mmmm............................mmmmmmmmmm........");
			Console.WriteLine("....mmmmm...................mmmmmmmmm..............");
			Console.WriteLine(".......mmmmmmmmmmmmmmmmmmmmmmmm....................");
			Console.ReadLine();
		}
	}
}
