using System;
using System.Linq;

namespace YieldReturn
{
    class Program
    {
        static void Main()
        {
            //foreach (var day in DayEnumeration.Weekend)
            //{
            //    Console.WriteLine(day);
            //}

            foreach(var val in Fibonacci.Sequence(20).Skip(5).Take(10))
                Console.WriteLine(val);
        }
    }
}
