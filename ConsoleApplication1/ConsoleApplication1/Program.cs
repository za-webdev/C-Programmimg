using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithCase
{
    class Program
    {
        public enum Colors
        {
            red,
            yellow,
            blue,
            pink
        }
        static void Main(string[] args)
        {
            var color = Colors.yellow;

          switch (color)
            {
                case Colors.pink:
                    Console.WriteLine("its pink");
                    break;

                case Colors.blue:
                    Console.WriteLine("its blue");
                    break;

                default:
                    Console.WriteLine("i dont know");
                    break;

            }

            
        }
    }
}
