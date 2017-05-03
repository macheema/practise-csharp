using System;
using DelegatesPredicates.ClockExample;
using LINQExample.PersonData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.LINQTest
{
    [TestClass]
    public class Test
    {
        private PersonService _service = new PersonService();
        [TestMethod]
        public void TestGroupData()
        {
            string[] data = _service.GetUniqPersonsStringKey();
            foreach (var key in data)
            {
                Console.WriteLine(key);
            }
        }

        [TestMethod]
        public void TestGroupDataCount()
        {
            int count = _service.GetUniqPersonsCount();
            Assert.AreEqual(6, count, "Data is not equal");
        }
        [TestMethod]
        public void TestPersonExist()
        {
            var person = new Person("Awais", "Cheema");
            Person guy = _service.IsExist(person);
            Assert.IsNotNull(guy);
        }
    }
}
