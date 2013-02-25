using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    class MyClass : BaseClass
    {
        //public double foo(double x, double y) 
        //{
        //    return x + y;
        //}

        public MyClass()
        {
            Console.WriteLine("MyClass");
        }

        
        //public override void foo()
        //{
        //    base.foo(); // sollte man aufrufen, da in der basisklasse member initialisiert werden können.
        //    Console.WriteLine("MyClass foo");
        //}
        //public bool foo(double x, double y) // lässt sich nicht kompilieren, da der rückgabetyp nicht zur Signatur gehört
        //{
        //    return x == y;
        //}
    }
}
