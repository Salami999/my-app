using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_app
{
    class Program
    {
        static void Main(string[] args)
        {
           
                try
                {
                    Console.WriteLine("Hell User");
                    Console.WriteLine("Input Miles driven");
                    double Mile = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the gallon used");
                    double Gallon = Convert.ToDouble(Console.ReadLine());

                    double Calculate = (Mile / Gallon);

                    Console.WriteLine("Miles per Gallon = " + Calculate + " MPG ");

                    Console.ReadLine();
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                     Console.ReadLine();
            }

                



            }
        }
    }
