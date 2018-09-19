using System;
using Example.Math;

namespace Example
{
    public enum Gender
    {
        male,
        female,
        unknown
    }
    class Person {
        public string firstname;
        public string lastname;
        public Gender gender;
        public bool isAlive;
       
        public void introduce()
        {
            var live = (isAlive) ? "alive" : "not alive";
            Console.WriteLine(string.Format("Name is {0} {1} and gender is {2} and is {3}",firstname,lastname,gender,live));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var me = new Person();
            me.firstname = "zoya";
            me.lastname = "ali";
            me.isAlive = true;
            me.gender = Gender.female;
            me.introduce();

        }
    }
}
