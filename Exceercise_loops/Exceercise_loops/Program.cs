using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceercise_loops
{
   public class PracticeLoops
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            /// Display the result on the console.
            /// </summary>

            //var count = 0;
            //for (var i = 1; i <= 100; i++)
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //Console.WriteLine(count);

            /// <summary>
            /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            /// </summary>

            //Console.WriteLine("Enter a number");
            //var sum = 0;
            //while (true)
            //{

            //    var input = Console.ReadLine();
            //    if (input.Equals("ok")) 
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        sum +=(Convert.ToInt32 (input));

            //        Console.WriteLine(sum);
            //    }
            //}

            /// <summary>
            /// Write a program which takes a single argument from the console, computes the factorial and prints the 
            /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            /// and display it as 5! = 120.
            /// </summary>

            //Console.WriteLine("enter a number");
            //var input = Convert.ToInt32(Console.ReadLine());
            //var output = 1;
            //for (var i = input; i >= 1; i--)

            //    output *= i;
            //Console.WriteLine("{0} != {1}", input, output);

            /// <summary>
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            /// </summary>

            //for (var i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine("Pick a number");
            //    var guess = Convert.ToInt32(Console.ReadLine());
            //    var random = new Random();

            //    var randomNum = random.Next(1, 10);
            //    if (guess == randomNum)
            //    {
            //        Console.WriteLine("You won");
            //        break;
            //    }
            //    if (guess != randomNum)
            //    {
            //        Console.WriteLine("You lost");

            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            /// <summary>
            /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            /// display 8 on the console.
            /// </summary>

            //Console.WriteLine("Enter a series");
            //var input = Console.ReadLine();
            //var max = input[0];

            //for (var i = 0; i < input.Length; i++)

            //    if (input[i] > max)
            //    {
            //        max = input[i];
            //    }

            //Console.WriteLine(max);











        }
    }
}
