using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RONIT
{
    internal class Program
    {
        public delegate void WhatIeat();
        public delegate void WhatIeats(string food);
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            Animal dog = new Animal("dog");
            cow.WhatIeat();
            WhatIeat eat = new WhatIeat(cow.WhatIeat);
            WhatIeats eats = new WhatIeats(dog.WhatIeat);
            eat();
            eats("bone");
            Console.ReadKey();

        }


    }
}
