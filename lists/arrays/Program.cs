using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public static void Unique()
        {
            var someNumbers = new List<int> { };
            var uniqueNumbers = new List<int> { };

            while (true)
            {
                Console.WriteLine("Enter a number or type Quit to exit");
                var input = Console.ReadLine();
                
                if (input.ToLower() == "quit")
                    break;

                else if (!input.All(char.IsDigit))
                    continue;
                else
                    someNumbers.Add(Convert.ToInt32(input));
            }

            foreach(var x in someNumbers)
            {
                if (!uniqueNumbers.Contains(x))
                    uniqueNumbers.Add(x);
            }
            foreach (var num in uniqueNumbers)
            {
                Console.Write(num + ",");
            }
        }

        public static  void Likes()
        {

            var names_list = new List<string> { };

            while (true)
            {
                Console.WriteLine("enter a name");
                var input = Console.ReadLine();
                names_list.Add(input);

                for (var i = 0; i < names_list.Count; i++)
                    if (names_list.Count == 1)
                    {
                        Console.WriteLine("{0} likes your post", names_list[0]);

                    }
                if (names_list.Count == 2)
                {
                    Console.WriteLine("{0} and {1} likes your post", names_list[0], names_list[1]);
                }
                if (names_list.Count > 2)
                {
                    Console.WriteLine("{0},{1} and {2} other likes your post", names_list[0], names_list[1], (names_list.Count) - 2);
                }
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
            }
        }

        public static void UniqueList()
        {
            /// <summary>
            /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.
            /// </summary>
            var numbers = new List<int> { };
            while (numbers.Count < 5)
            {
                Console.WriteLine("enter a number");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("err");
                    continue;
                }
                else
                    numbers.Add(input);
            }
            numbers.Sort();
            foreach (var num in numbers)
            {
                Console.Write(num + ",");
            }

        }

        public static void FindMin()
        {
            var myList = new List<int> { };
            while (true)
            {
                Console.WriteLine("Enter a list of number");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid");
                    continue;
                }
                else
                {
                    string[] numbers=input.Split(',');
                    foreach(var num in numbers)
                    {
                        myList.Add(Convert.ToInt32(num));
                    }
                    
                    break;
                }
            }
            
            var min = myList[0];
            var i = 0;
            while (i < 3)
            {
                for (var j = 0; j < myList.Count; j++)
                {

                    if (myList[j] < min)
                    {
                        min = myList[j];
                    }
                    Console.WriteLine(min);
                }
               
                i++;
            }
                

        }
        static void Main(string[] args)
        {
            Unique();
            Likes();
            UniqueList();
            FindMin();


            var numbers = new[] { 1, 2, 3, 4, 5, 6 };

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var another = new int[4];
            Array.Copy(numbers, another, 3);
            foreach (var x in another)
            {
                Console.WriteLine("another" + x);
            }

            var newNumbers = new List<int> { 1, 3, 4, 5 };

            var random = new Random();
            var buffer = new char[10];
            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var pass = new string(buffer);
            Console.WriteLine(pass);

        }
    }
}

