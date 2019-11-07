using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppveyorTest;

namespace AppveyorTest.Net452
{
    class Program
    {
        static void Main(string[] args)
        {
            AppveyorTestClass testClass = new AppveyorTestClass();
            Console.WriteLine(testClass.TestMethod(true));
            Console.ReadLine();
        }
    }
}
