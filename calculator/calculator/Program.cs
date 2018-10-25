using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    
    class Calculator
    {
        bool valid = true;
        public void Add()
        {
            while (valid)
            {
                Console.WriteLine("enter first number");
                var num1 = Console.ReadLine();

                if (num1.ToLower() == "exit")
                    valid=false;

                if (!num1.All(char.IsDigit))
                {
                    Console.WriteLine("invalid");
                    valid = true;
                }

                Console.WriteLine("enter second number");
                var num2 = Console.ReadLine();

                if (num2.ToLower() == "exit")
                    valid=false;

                //if (!num2.All(char.IsDigit))
                //{
                //    Console.WriteLine("invalid");
                //    continue;
                //}
                 
                var sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                    Console.WriteLine("Sum is {0}:",sum);
            }
        }

        public void Multiply()
        {
            while (true)
            {
               
                Console.WriteLine("enter first number");
                var num1 = Console.ReadLine();
                if (num1.ToLower() == "exit")
                    return;
                if (!num1.All(char.IsDigit))
                {
                    Console.WriteLine("invalid");
                    continue;
                }

                Console.WriteLine("enter second number");
                var num2 = Console.ReadLine();
                if (num2.ToLower() == "exit")
                    return;

                if (!num2.All(char.IsDigit))
                {
                    Console.WriteLine("invalid");
                    continue;
                }

                var answer = Convert.ToInt32(num1) * Convert.ToInt32(num2);
                    Console.WriteLine("Answer is :{0} ",answer);
            }
        }

        public void Divide()
        {
            while (true)
            {
                Console.WriteLine("enter first number");
                var num1 = Console.ReadLine();
                if (num1.ToLower() == "exit")
                    return;
                if (!num1.All(char.IsDigit))
                {
                    Console.WriteLine("invalid");
                    continue;
                }

                Console.WriteLine("enter second number");
                var num2 = Console.ReadLine();
                if (num2.ToLower() == "exit")
                    return;

                if (!num2.All(char.IsDigit))
                {
                    Console.WriteLine("invalid");
                    continue;
                }

                if (Convert.ToInt32(num1) == 0 || Convert.ToInt32(num2) == 0)
                    Console.WriteLine("Err");

                else
                {
                    var result = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                    var remainder = Convert.ToInt32(num1) % Convert.ToInt32(num2);
                    Console.WriteLine("{0} and reaminder is {1}", result, remainder);
                }
                   
            }
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Choose option (add,multiply,divide)");
            var input = Console.ReadLine();

            if (input.ToLower() == "add" || input == "+")
            {
                cal.Add();
            }
            else if (input.ToLower() == "multiply" || input == "*")
            {
                cal.Multiply();
            }
            else if (input.ToLower() == "divide" || input == "/")
            {
                cal.Divide();
            }
            else
            {
                Console.WriteLine("Please select from the provided options");
            }
        }

    }
   
}
