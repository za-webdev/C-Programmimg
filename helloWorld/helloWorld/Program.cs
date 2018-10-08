using System;
using System.Collections.Generic;
using System.Linq;

namespace helloWorld
{
    class Program
    {
        Random rnd = new Random();
        List<string> myfruits = new List<string>();
        int i;
        
        void GetRandomFruit()
        {
            while(i < 10)
            {
               string[] fruits = new []{ "apple", "mango", "papaya", "banana", "guava", "pineapple", "maths", "chem","bie","heloo","kkk","llll" };
                string fruit=fruits[rnd.Next(0, fruits.Length)];
                if (!myfruits.Contains(fruit))
                {
                    myfruits.Add(fruit);
                }
                
                i++;
            }
            foreach(var i in myfruits)
            {
                Console.WriteLine(i);
            }
        }
        void Dups()
        {
            List<string> first = new List<string> { "apple","mango", "apple", "mango", "papaya"};
        }
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.GetRandomFruit();

            Console.ReadLine();


        }
    }
}
