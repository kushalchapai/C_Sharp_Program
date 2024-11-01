using System;
namespace C_Sharp_program {
    public class Q10
    {
        public static void Speed()
        {
            // Input distance in meters
            Console.Write("Input distance (metres): ");
            double distanceInMeters = Convert.ToDouble(Console.ReadLine());

            // Input time in hours, minutes, and seconds
            Console.Write("Input time (hours): ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input time (minutes): ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input time (seconds): ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            //convert total time to seconds
            double totalTimeInSeconds = seconds+ (hours*60*60) + (minutes*60) ;

            // Convert total time to hours
            double totalTimeInHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Convert distance to kilometers
            double distanceInKilometers = distanceInMeters / 1000.0;

            //Convert distance to miles
            double distanceInMiles = distanceInMeters / 1609.34;

            //Calculate speed in meteres/sec
            double speedInMS = distanceInMeters / totalTimeInSeconds;

            // Calculate speed in km/h
            double speedInKmh = distanceInKilometers / totalTimeInHours;

            // Calculate speed in miles/h
            double speedInMph = distanceInMiles / totalTimeInHours;

            // Display results
            Console.WriteLine("Your speed in metres/sec is "+speedInMS);
            Console.WriteLine("Your speed in km/h is "+speedInKmh);
            Console.WriteLine("Your speed in miles/h is "+speedInMph);
        }
    }
}