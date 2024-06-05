using System;
using System.Collections.Generic;
using YourProject.Activities; // Ensure this matches your actual project namespace

namespace YourProject
{
    public class Program
    {
        public static void Main()
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2022, 11, 3), 30, 4.8),
                new Cycling(new DateTime(2022, 11, 3), 30, 20),
                new Swimming(new DateTime(2022, 11, 3), 30, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
