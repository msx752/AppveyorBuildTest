using System;

namespace AppveyorTest
{
    public class AppveyorTestClass
    {
        public string TestMethod(bool testState)
        {
            return $"TestMethod is worked and param:TestState value is '{testState}'";
        }
    }
}
