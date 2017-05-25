
using System;
using System.Collections;
namespace WorkingWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            B objB = new B();
            objB.PrintCount();
        }
    }
    public class B
    {
        public readonly int count = 5;
        public B()
        {
            count = 10;
        }

        public void PrintCount()
        {
            //count = 15;
            Console.WriteLine(count);
        }
    }
    public class D:B
    {
    }
}
