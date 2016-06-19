namespace Defining_classes
{
    using System;

    class Battery
    {
        public string Model { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(double hoursIdle, double hoursTalk)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}
