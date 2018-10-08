using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace strings2
{
    class Program
    {
        public static string result;
        public static string DoSomething(string input)
        {
            var result = "";
            var sentence = input.Split(' ');
            
            for (var i = 0; i < sentence.Length; i++)
            {
               
                var str = char.ToUpper(sentence[i][0]) + sentence[i].ToLower().Substring(1);
                result += str;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence");
            var input = Console.ReadLine();
            var x =DoSomething(input);
            Console.WriteLine(x);
        }

    }
}
