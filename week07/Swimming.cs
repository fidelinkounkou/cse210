namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps;

        public Swimming(string date, int minutes, int laps) : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50.0 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistance();
        }

        public override string GetSummary()
        {
            return GetDate() + " Swimming (" + GetMinutes() + " min) - Distance: " + GetDistance() + " miles, Speed: " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile";
        }
    }
}
