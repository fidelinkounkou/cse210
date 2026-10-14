using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> listeActivites = new List<Activity>();

            Running course = new Running("03 Nov 2022", 30, 3.0);
            Cycling velo = new Cycling("04 Nov 2022", 45, 12.0);
            Swimming natation = new Swimming("05 Nov 2022", 20, 40);

            listeActivites.Add(course);
            listeActivites.Add(velo);
            listeActivites.Add(natation);

            foreach (Activity act in listeActivites)
            {
                Console.WriteLine(act.GetSummary());
            }
        }
    }
}
