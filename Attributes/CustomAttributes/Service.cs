using System;
using System.Linq;
using System.Reflection;

namespace Attributes.CustomAttributes
{
    public class Service
    {
        [Security(Role = 1, Secure = false)]
        public void Method()
        {
        }
        [Security(Role = 1, Secure = true)]
        public void SecureMethod()
        {

        }

        public static void Main()
        {
            var mthds = (from methods in (from t in Assembly.GetExecutingAssembly().GetTypes()
                                          select t.GetMethods())
                         select methods);
            Console.WriteLine(mthds.GetType());
            foreach (MethodInfo[] methods in mthds)
            {
                foreach (MethodInfo method in methods)
                {
                    var attrs = method.GetCustomAttributes<SecurityAttribute>();
                    foreach (var attr in attrs)
                    {
                        Console.WriteLine(method.Name);
                        break;
                    }
                }
            }
        }
    }
}
