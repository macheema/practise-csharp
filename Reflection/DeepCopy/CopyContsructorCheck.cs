using System;
using System.Reflection;

namespace Reflection.DeepCopy
{
    class Student
    {
        public Student(int capacity)
        {
            if (capacity < 1)
            {
                throw new TargetParameterCountException("Invalid Arument Exception capacity=" + capacity);
            }
            Courses = new string[capacity];
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Courses { get; set; }

        public Student(ref Student student)
        {
        }
    }
    class CopyContsructorCheck
    {

        public void AddCourse(Student student, int index, string course)
        {
            if (index < 0 && index >= student.Courses.Length)
            {
                throw new IndexOutOfRangeException();
            }
            student.Courses[index] = course;
        }
    }
}
