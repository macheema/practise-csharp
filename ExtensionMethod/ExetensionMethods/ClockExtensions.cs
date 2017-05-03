using System;
using System.Reflection;
using DelegatesPredicates.ClockExample;

namespace ExtensionMethod.ExetensionMethods
{
    public static class ClockExtensions
    {
        public static void Tick_1_PM(this ClockTower clock)
        {
            var memberInfo = clock.GetType().GetField("ClockTick", BindingFlags.Instance | BindingFlags.NonPublic);
            if (memberInfo != null)
            {
                var eventDelegate = (MulticastDelegate)memberInfo.GetValue(clock);
                if (eventDelegate != null)
                {
                    foreach (var handler in eventDelegate.GetInvocationList())
                    {
                        handler.Method.Invoke(handler.Target, new object[] { clock, new ClockEventArgs { Time = new DateTime(1970, 1, 1, 13, 0, 0) } });
                    }
                }
            }
        }
        public static void Tick_2_PM(this ClockTower clock)
        {
            var memberInfo = clock.GetType().GetField("ClockTick", BindingFlags.Instance | BindingFlags.NonPublic);
            if (memberInfo != null)
            {
                var eventDelegate = (MulticastDelegate)memberInfo.GetValue(clock);
                if (eventDelegate != null)
                {
                    foreach (var handler in eventDelegate.GetInvocationList())
                    {
                        handler.Method.Invoke(handler.Target, new object[] { clock, new ClockEventArgs { Time = new DateTime(1970, 1, 1, 14, 0, 0) } });
                    }
                }
            }
        }
    }
}
