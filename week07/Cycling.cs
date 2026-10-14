namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double speed;

        public Cycling(string date, int minutes, double speed) : base(date, minutes)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (speed * GetMinutes()) / 60;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / speed;
        }

        public override string GetSummary()
        {
            return GetDate() + " Cycling (" + GetMinutes() + " min) - Distance: " + GetDistance() + " miles, Speed: " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile";
        }
    }
}
