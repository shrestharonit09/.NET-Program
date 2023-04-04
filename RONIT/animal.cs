using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONIT
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("i am an animal");
        }
        public void WhatIeat()
        {
            Console.WriteLine("i eat grass");
        }
        public Animal(string name)
        {
        Console.WriteLine(" i am"+name); 
        }
        public void WhatIeat(string food)
        {
            Console.WriteLine("i eat "+ food);
        }
    }
}
