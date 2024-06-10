using System;
using System.Collections.Generic;
using MyActivity.Activities;

namespace MyActivity
{
    public class Program
    {
        public static void Main()
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2002, 09, 1), 24, 6),
                new Cycling(new DateTime(2024, 07, 2), 26, 7.2),
                new Swimming(new DateTime(2024, 12, 3), 25, 54)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
