using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>
            /// 
             Console.WriteLine("Enter a number");
             var input = Console.ReadLine();
             var num = Convert.ToInt32(input);
             if (num >= 1 && num <= 10)
                 Console.WriteLine("valid");
             else
                 Console.WriteLine("Invalid");


            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            /// 

            Console.WriteLine("Enter a number");
            var input1 = Console.ReadLine();
            var num1 = Convert.ToInt32(input1);
            Console.WriteLine("Enter another number");
            var input2 = Console.ReadLine();
            var num2 = Convert.ToInt32(input2);

            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("max is: " + max);


            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>
            /// 

            Console.WriteLine("Enter height of the image");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of the image");
            var width = Convert.ToInt32(Console.ReadLine());

            if (width > height)
                Console.WriteLine("Landsacpe");
            else
                Console.WriteLine("Potriat");

            /// <summary>
            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>

            Console.WriteLine("Enter speed limit");
            var speed_limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car speed");
            var car_speed = Convert.ToInt32(Console.ReadLine());

            if (car_speed < speed_limit)
                Console.WriteLine("ok");
            else
            {
                var demeritPoints = (car_speed - speed_limit )/ 5;
                Console.WriteLine("Demerit Points are " + demeritPoints);
                if (demeritPoints >= 12)
                {
                    Console.WriteLine("Lisence suspended");
                }
            }
                




        }
    }
}
