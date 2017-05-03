using System.Reflection;
using Attributes.CustomAttributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Attributes.AttributeTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CheckSecureMethod()
        {
            MethodInfo method = typeof(Service).GetMethod("SecureMethod");
            var attr = method.GetCustomAttribute<SecurityAttribute>();
            if (attr != null && attr.Secure == false)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void CheckMethod()
        {
            MethodInfo method = typeof(Service).GetMethod("Method");
            var attr = method.GetCustomAttribute<SecurityAttribute>();
            if (attr.Secure == true)
            {
                Assert.Fail();
            }
        }
    }
}
