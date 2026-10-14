using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string date;
        private int minutes;

        public Activity(string date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public string GetDate()
        {
            return date;
        }

        public int GetMinutes()
        {
            return minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            
            return date + " Activity (" + minutes + " min) - Distance: " + GetDistance() + " miles, Speed: " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile";
        }
    }
}
