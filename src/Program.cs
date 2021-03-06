﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
       
        static Func<int, int, int> add = (a, b) => a + b;
        static Func<int, int, int, int> add2 = (a, b, c) => a + b + c;

        static void Main(string[] args)
        {
            // inc1 --> currying
            Func<int, Func<int, int>> curriedAdd = add.Curry();
            Func<int, int> increment1 = curriedAdd(1); // vergl. zu ++-Operator durch currying
            // inc2 --> patial function application 
            Func<int, int> increment2 = add.Partial(1); // vergl. zu ++-Operator durch partial function application

            Console.WriteLine(increment1(2)); // 3
            Console.WriteLine(increment2(2)); // 3

            Console.WriteLine(curriedAdd);
            var x = Extensions.Partial<int, int, int>((a, b) => a + b, 3);
            var y = x(3);

            Func<int, Func<int, Func<int, int>>> curriedAdd2 = add2.Curry2();

            Console.WriteLine("curriedAdd1: " + curriedAdd2(1)(2)(3)); // 6

            Console.WriteLine("x: " + x + "\ny: " + y);

            /*
            var numbers_1 = new List<int>();
            numbers_1.Add(1);

            IEnumerable<int> query_1 = numbers_1.Select(n => n * 10);

            numbers_1.Add(2);

            query_1.ToList().ForEach(Console.WriteLine);

            //###########################################################
            Console.WriteLine("\n\n");
            //###########################################################

            var numbers_2 = new List<int>();

            numbers_2.Add(1); IEnumerable<int> query_2 = numbers_2.Select(n => n * 10).ToList();

            numbers_2.Add(2);

            query_2.ToList().ForEach(Console.WriteLine);

            string ad = "Wirtz.Nicolai@kermi.de";
            Console.WriteLine(ad);

            Console.WriteLine("Konstruktortest\n");

            MyClass mC = new MyClass();

            mC.foo();

            Console.WriteLine();


            int myVal = 0;
            ChangeValToTen(ref myVal);
            Console.WriteLine("myVal: " + myVal);

            MyNum drei = new MyNum(3);
            MyNum sechs = new MyNum(6);

            Swap<MyNum>(ref drei, ref  sechs);

            Console.WriteLine("drei " + drei.Num + " :: sechs " + sechs.Num);

            //decimal i = 2.3m;
            //decimal x = 2.4m;

            //Func<decimal, decimal, bool> valid = (a, b) => a < b;

            //Console.WriteLine(valid(i, x));
            */

            Console.ReadKey();
        }
    }
}


//SetCursorPos(900, 500);

//POINT p;
//uint pixel;
//IntPtr hdc;
//IntPtr z = new IntPtr(0);
//hdc = GetDC(z);
//int r = 0;
////hdc = GetDC(z);

//while (true) 
//{
//    hdc = GetDC(z);
//    GetCursorPos(out p);
//    pixel = GetPixel(hdc, p.X, p.Y);
//    r = ReleaseDC(z, hdc);
//    //if (pixel == 4294967295) // wenn pixel außerhalb des Auswahlbereichs (normalerweise ist der ganze Bildschierm der auswahlbereich duch IntPtr(0) 
//    //    r = ReleaseDC(z, hdc);
//    //    hdc = GetDC(z);

//    if (r == 1) Console.WriteLine("DC released");
//    else Console.WriteLine("DC NOT released");

//    Console.WriteLine("x: {0} - y: {1}", p.X, p.Y);
//    Console.WriteLine("color: 0x{0}", pixel.ToString("X"));
//    Thread.Sleep(30);
//    Console.Clear();

//}


//MessageBox(new IntPtr(0), "Hello World!", "Hello Dialog", 0);

// Die Zwei "froms" sind zu vergleichen mit geschachteltet "foreach"
//var pairs =
//    from a in numbersA
//    from b in numbersB
//    where a < b
//    select new { a, b };

//Console.WriteLine("Pairs where a < b:");
//foreach (var pair in pairs)
//{
//    Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
//    //Console.ReadKey();
//}

//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
////var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
//var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);


//foreach (var item in firstSmallNumbers)
//{
//    Console.WriteLine(item);
//}

//int x;
//string s = Console.ReadLine();
//x = Convert.ToInt32(s);

//myDel del;

//switch (x) 
//{
//    case 1:
//        del = a => a * a;
//        Console.WriteLine(del(3));
//        break;
//    case 2:
//        del = a => a + a;
//        Console.WriteLine(del(3));
//        break;
//}

//Expression<Func<int, bool>> lambda = num => num < 5;
//Console.Write(lambda);

//// Add the following using directive to your code file:
//// using System.Linq.Expressions;

//// Manually build the expression tree for 
//// the lambda expression num => num < 5.
//ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
//ConstantExpression five = Expression.Constant(5, typeof(int));
//BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
//Expression<Func<int, bool>> lambda1 =
//    Expression.Lambda<Func<int, bool>>(
//        numLessThanFive,
//        new ParameterExpression[] { numParam });

//Console.WriteLine();
//Console.WriteLine(lambda1);

//var list = new List<decimal>();
//list.Add(23.34m);
////list.Add("k");

//for (int i = 0; i < 2; i++) 
//{
//    decimal myd = 0m;

//    if(!decimal.TryParse(list.ElementAt(i) + "", out myd))
//    {
//        Console.WriteLine(list.ElementAt(i) + "");
//    }
//    else Console.WriteLine(list.ElementAt(i));

//}