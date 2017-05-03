using System;

namespace DelegatesPredicates.MyDelegates
{
    public delegate int Calculate(int num1, int num2);

    public class DelegatesClass
    {

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return Math.Abs(num1 - num2);
        }
    }
}
