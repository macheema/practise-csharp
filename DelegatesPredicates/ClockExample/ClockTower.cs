using System;

namespace DelegatesPredicates.ClockExample
{

    public delegate void ClockEventHandler(object sender, EventArgs e);

    public class ClockTower
    {
        public event ClockEventHandler ClockTick;

        public void Tick_8_AM()
        {
            ClockTick?.Invoke(this, new ClockEventArgs { Time = new DateTime(1970, 1, 1, 08, 00, 00) });
        }
        public void Tick_9_AM()
        {
            ClockTick?.Invoke(this, new ClockEventArgs { Time = new DateTime(1970, 1, 1, 09, 00, 00) });
        }
        public void Tick_6_PM()
        {
            ClockTick?.Invoke(this, new ClockEventArgs { Time = new DateTime(1970, 1, 1, 18, 00, 00) });
        }
        public void Tick_7_PM()
        {
            ClockTick?.Invoke(this, new ClockEventArgs { Time = new DateTime(1970, 1, 1, 19, 00, 00) });

        }

    }
}
