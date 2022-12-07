using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private string Name;
        private int Age;
        /* public string Name { get; set; }
         public int Age { get; set; }*/
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Print()
        {

            Console.WriteLine($"{Name}");

            Console.WriteLine($"{Age}");
        }

        public void JoinEx()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Second Thread: {i}");
               /* Thread.Sleep(100);*/
            }
        }


    }
}
