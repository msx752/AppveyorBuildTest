using System;
using AppveyorTest;

namespace AppveyorTest.NetCore
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
