using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    class ClassA: ClassB
    {
        public void Display1()
        {
            Console.WriteLine("ClassA Display1");
            base.Display1();
        }
    }
}
