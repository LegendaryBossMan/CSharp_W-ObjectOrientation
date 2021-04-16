using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNBDay9Assignment
{
	class Program
	{

		class Shape
		{
			public void setBase(int b)
			{
				Base = b;
			}

			public void setHeight(int h)
			{
				height = h;
			}

			protected int Base;// 
			protected int height;
		}//End of shape clas

		class Rectangle : Shape
		{
			public int getArea()
			{

				return (Base * height);
			}
		}//end rectangle
		class Square : Shape
		{
			public int getArea()
			{
				return (Base * height);
			}
		}//end square
		class Triangle : Shape
		{
			public int getArea()
			{
				return (1 / 2 * (Base * height));
			}
		}//end triangle

		class Trapezoid : Shape
		{
			protected int Base1;
			protected int Base2;
			public void setBase1(int a)
			{
				Base1 = a;
			}
			public void setBase2(int b)
			{
				Base2 = b;
			}
			public int getArea()
			{
				return (1 / 2 * (Base1 + Base2) * height);
			}
		}//end Trapezoid
		class Parellelogram : Shape
		{
			public int getArea()
			{
				return (Base * height);
			}
		}//end Parellelogram
		static void Main(string[] args)
		{
			/*Create a program that allows the user to enter a Base and a Height (and any other needed info). With those entered, the user can request the area of any of the following shapes:

			Rectangle = Base X Height;
			Square = Base X Height;
			Triangle = ½(Base X Height);
			Parallelogram = Base X Height;
			Trapezoid = ½ (Base1 + Base2) X Height
			Circle = Pi(radius)2 = Pi(r)2 */
			Rectangle Rect = new Rectangle();
			//Circle Cir = new Circle();
			Trapezoid Trap = new Trapezoid();
			Parellelogram Par = new Parellelogram();
			Triangle Tri = new Triangle();
			Square Squ = new Square();
			string shape;

			Console.WriteLine("What shape do you want to calculate the area of?(Rectangle, Square, Triangle, Parallelogram, Trapezoid  or Circle): ");
			shape = Console.ReadLine();

			switch (shape)
			{
				case "Rectangle":
					{
						int a;
						int b;
						Console.WriteLine("Enter the base of your Rectangle: ");
						a = Convert.ToInt32(Console.ReadLine());
						Rect.setBase(a);
						Console.WriteLine("Enter height of your Rectangle: ");
						b = Convert.ToInt32(Console.ReadLine());
						Rect.setHeight(b);
						int area = Rect.getArea();
						Console.WriteLine("The total area of the Rectangle is: {0}", area);
						break;
					}//end class rectangle
				case "Square":
					{
						int a;
						int b;
						Console.WriteLine("Enter the base of your Square: ");
						a = Convert.ToInt32(Console.ReadLine());
						Squ.setBase(a);
						Console.WriteLine("Enter height of your Square: ");
						b = Convert.ToInt32(Console.ReadLine());
						Squ.setHeight(b);
						int area = Squ.getArea();
						Console.WriteLine("The total area of the Square is: {0}", area);

						break;
					}//end case square.  I hate comments, at times.
				case "Triangle":
					{
						int a;
						int b;
						Console.WriteLine("Enter the base of your Triangle: ");
						a = Convert.ToInt32(Console.ReadLine());
						Tri.setBase(a);
						Console.WriteLine("Enter height of your Triangle: ");
						b = Convert.ToInt32(Console.ReadLine());
						Tri.setHeight(b);
						int area = Rect.getArea();
						Console.WriteLine("The total area of the Triangle is: {0}", area);
						break;
					}//end case triangle
				case "Parallelogram":
					{
						int a;
						int b;

						Console.WriteLine("Enter the base of your Parallelogram: ");
						a = Convert.ToInt32(Console.ReadLine());
						Par.setBase(a);
						Console.WriteLine("Enter height of your Triangle: ");
						b = Convert.ToInt32(Console.ReadLine());
						Par.setHeight(b);
						int area = Rect.getArea();
						Console.WriteLine("The total area of the Triangle is: {0}", area);
						break;
					}//end case parallelogram
				case "Trapezoid":
					{
						int a;
						int b;
						int c;
						Console.WriteLine("Enter the base of your Trapezoid: ");
						a = Convert.ToInt32(Console.ReadLine());
						Trap.setBase1(a);
						Console.WriteLine("Enter the second base of your Trapezoid: ");
						b = Convert.ToInt32(Console.ReadLine());
						Trap.setBase1(b);
						Console.WriteLine("Enter height of your Triangle: ");
						c = Convert.ToInt32(Console.ReadLine());
						Par.setHeight(c);
						int area = Rect.getArea();
						Console.WriteLine("The total area of the Triangle is: {0}", area);
						break;
					}//end case trapezoid
				case "Circle":// had an issue with circle class but here it is.
					{
						// Area of a circle: A=πr2
						Console.WriteLine("Write the radius of the circle: ");
						double radius = double.Parse(Console.ReadLine());
						double pi = Math.PI;
						double area = pi * (radius * radius);
						Console.WriteLine("The Area (A=πr2) of your circle is: {0:0.00}", area);
						Console.ReadKey();
						break;
					}//end of case Circle
				default:
					{
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
						break;
					}//end of default

			}//end of switch
		}//end main
	}//end class 
}//end namespace
