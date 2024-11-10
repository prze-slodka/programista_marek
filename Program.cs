using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            // before we construct a submarine, test individual elements of the program first
            bool testsPassed = TestSubmarine.Run();
            if (!testsPassed) return;
            Console.WriteLine(testsPassed);

            // now we are ready for the submarine simulation
            Submarine.Demo();
        }
    }
}
