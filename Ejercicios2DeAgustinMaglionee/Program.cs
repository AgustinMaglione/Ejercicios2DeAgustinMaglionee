using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2DeAgustinMaglionee
{
    class Program
    {
        static void Main(string[] args)
        {
			double a;
			double b;
			double c;
			double d;
			double e;
			Console.WriteLine("ingrese el numero 1 ");
			a = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el numero 2 ");
			b = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el numero 3 ");
			c = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el numero 4 ");
			d = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el numero 5 ");
			e = Double.Parse(Console.ReadLine());
			if (a == 0 && b == 0)
			{
				Console.WriteLine("Ambos terminos A y B son iguales a 0 y no se puede conformar una conica");
			}
			else
			{
				if (a != 0 || b != 0)
				{
					Console.WriteLine(" Es una parabola");
				}
				if (a != 0 && b != 0 && a == b && b == a)
				{
					Console.WriteLine(" Es una circunferencia");
				}
				if (a != 0 && b != 0 && a != b && a > 0 && b > 0)
				{
					Console.WriteLine(" Es elipse ");
				}
				if (a != 0 && b != 0 && a != b)
				{
					if (a > 0 && b > 0 || a < 0 && b > 0)
					{
						Console.WriteLine(" Es una hiperbola");
					}
				}
			}
			Console.ReadLine();
		}
		
        }
    }

