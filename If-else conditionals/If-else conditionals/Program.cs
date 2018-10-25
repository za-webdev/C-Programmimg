using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = 15;

            if( num >=1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public int Test()
        {
            return 25;
        }

        public string CheckValidity(int num)
        {
            if (num >= 1 && num <= 10
                )
            {
                 return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
