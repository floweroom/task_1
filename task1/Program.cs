using System;
using System.Diagnostics.Contracts;


namespace ConsoleApp64
{
   public class Person
   {

        public string name { get; private set; }
        public int age { get; private set; }


        public Person(string Name, int Age)
        {
            

            Name = name;
            Age = age;
        }

        public  Person Sub()
        {
            return new Person(name, age - 1);

        }


        class Program
        {

            public static void Main()
            {
                Person person = new Person("Sasha",  24);
                
            }

        }
    }

}
