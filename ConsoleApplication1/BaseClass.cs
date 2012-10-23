using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BaseClass
    {
        //public BaseClass() 
        //{
        //    Console.WriteLine("BaseClass\n");
        //}

        public virtual void foo() 
        {
            Console.WriteLine("Base foo");
        }

        //protected virtual void bar() { } 
        

    }
}
