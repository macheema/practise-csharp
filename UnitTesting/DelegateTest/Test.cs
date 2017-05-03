using DelegatesPredicates.LoggerUtility;
using DelegatesPredicates.MyDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.DelegateTest
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void TestSum()
        {
            var method = new Calculate(DelegatesClass.Sum);
            Assert.AreEqual(2, method(1, 1));
        }
        [TestMethod]
        public void TestSubtract()
        {
            var method = new Calculate(DelegatesClass.Subtract);
            Assert.AreEqual(0, method(1, 1));
        }
        [TestMethod]
        public void TestSumSubtract()
        {
            var method = new Calculate(DelegatesClass.Sum);
            Assert.AreEqual(2, method(1, 1));
        }

        [TestMethod]
        public void TestLogging()
        {
            var fl = new FileLogger("temp.txt");
            Logger logger = new Logger(fl);
            logger.Log("Yuppy");
            fl.Close();
        }
        [TestMethod]
        public void TestExpression()
        {
            Logger logger = new Logger(new ConsoleLogger());
            logger.LogEvent += msg =>
            {
                Assert.AreEqual("Yuppy", msg);
            };
            logger.Log("Yuppy");
        }

    }
}
