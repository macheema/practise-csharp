using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reflection.DeepCopy;

namespace Reflection.Test
{
    [TestClass]
    public class CopyConstructionTest
    {
        [TestMethod]
        public void CheckValue()
        {
            Student student = new Student(10);
            CopyContsructorCheck check = new CopyContsructorCheck();
            check.AddCourse(student, 0, "OOP");
            Assert.AreEqual("OOP", student.Courses[0], "C# doesn't deep copy");
        }
    }
}
