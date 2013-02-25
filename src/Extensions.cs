using System;

namespace ConsoleApplication1
{
    static class Extensions
    {
        // partial function application
        // reduziert eine funktion um genau n-1 parameter (hier eine funktion von 2 auf (2-1) Parameter
        public static Func<B, R> Partial<A, B, R>(this Func<A, B, R> f, A a)
        {
            return b => f(a, b);
        }
        
        // currying reduziert jede funktion auf genau einen Parameter

        // currying von funktionen mit 2 eingabeparametern
        public static Func<A, Func<B, C>> Curry<A, B, C>(this Func<A, B, C> f)
        {
            return a => b => f(a, b); // Bsp.: int -> int -> int
        }

        // currying von funktionen mit 3 eingabeparametern
        public static Func<A, Func<B, Func<C, D>>> Curry2<A, B, C, D>(this Func<A, B, C, D> f)
        {
            return a => b => c => f(a, b, c); // Bsp.: int -> int -> int -> int
        }
    }
}
