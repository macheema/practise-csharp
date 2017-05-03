using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplicitTypings.ConversionNS;
namespace ImplicitTypings.ConversionTest
{
    [TestClass]
    public class ImplicitTest
    {
        [TestMethod]
        public void Test_Implicit_String()
        {
            var obj = new ConversionClass();
            var name = obj.DoSomeImplicit();
            Assert.AreEqual(name, "awais cheema");
        }
    }
}
