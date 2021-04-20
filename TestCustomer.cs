using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProgram
{
    public class TestCustomer
    {
     public void TestType()
        {
            Type type = Type.GetType("ReflectionProgram.Customer");
            Console.WriteLine("Fetching customer class fullname" + type.FullName);
            Console.WriteLine("Fetching customer class fullname" + type.Name);

            //printing constructors
            Console.WriteLine("Constructors present in customer class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            //printing methods
            Console.WriteLine("methods present in customer class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ToString());
            }

            //printing property
            Console.WriteLine("Properties present in customer class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Methods are {0}{1}" +property.PropertyType.Name + "" +property.Name);
            }
        }
    }
}
