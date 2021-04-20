using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomer testCustomer = new TestCustomer();
            testCustomer.TestType();
            Console.ReadLine();
        }
    }
}
