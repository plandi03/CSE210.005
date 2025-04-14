using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking Program\n");

        // Create activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2023, 4, 14), 30, 3.0), // 3 miles in 30 minutes
            new Cycling(new DateTime(2023, 4, 13), 45, 15.0), // 15 mph for 45 minutes
            new Swimming(new DateTime(2023, 4, 12), 20, 30) // 30 laps in 20 minutes
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}