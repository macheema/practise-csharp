using DelegatesPredicates.ClockExample;
using ExtensionMethod.ExetensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.ClockEventTest
{
    [TestClass]
    public class Test
    {
        ClockTower clock;
        Person person;
        public Test()
        {
            clock = new ClockTower();
            person = new Person(clock);
        }

        [TestMethod]
        public void TestOnWay()
        {
            clock.Tick_8_AM();
            Assert.AreEqual(LocationEnum.OnWay, person.Location);
            clock.Tick_6_PM();
            Assert.AreEqual(LocationEnum.OnWay, person.Location);
        }
        [TestMethod]
        public void TestInOffice()
        {
            clock.Tick_9_AM();
            Assert.AreEqual(LocationEnum.InOffice, person.Location);
            clock.Tick_2_PM();
            Assert.AreEqual(LocationEnum.InOffice, person.Location);
        }
        [TestMethod]
        public void TestAtHome()
        {
            clock.Tick_7_PM();
            Assert.AreEqual(LocationEnum.AtHome, person.Location);
        }
        [TestMethod]
        public void TestInCafe()
        {
            clock.Tick_1_PM();
            Assert.AreEqual(LocationEnum.InCafe, person.Location);
        }
    }
}
