using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RONIT
{

    public class animal
    {
        public void WhatIEat()
        {
            Console.WriteLine("I eat grass");
        }
        public void WhatIEat(string Food)
        {
            Console.WriteLine(" I eat" + Food);
        }
        public void WhatIEat(string Food1, string Food2)
        {
            Console.WriteLine("I eat" + Food1 + "and" + Food2);
        }
    }

}
