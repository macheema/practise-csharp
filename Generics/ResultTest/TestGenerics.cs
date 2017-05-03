using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics.Result;
namespace Generics.ResultTest
{
    [TestClass]
    public class TestGenerics
    {
        [TestMethod]
        public void TestIntMethod()
        {
            ResultService service = new ResultService();
            var resultGint = service.GetResult<bool, int>(true, 1);
            var resultInt = service.GetResultInt(true, 1);
            Assert.AreEqual(resultGint, resultGint);

        }

        [TestMethod]
        public void TestStringMethod()
        {
            ResultService service = new ResultService();
            var resultGString = service.GetResult<bool, string>(true, "a");
            var resultString = service.GetResultString(true, "a");
            Assert.AreEqual(resultGString, resultGString);
        }
    }
}
