using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    int userAgeYears;
    int userAgeDays;
    int userAgeMinutes;
    int totalHeartbeats;
    int avgBeatsPerMinute;
  
    // Get userAgeYears from input
    userAgeYears = 19;
   
    // Calculate days w/o leap year
    userAgeDays = userAgeYears * 365;
   
    // Add days for leap years
    userAgeDays = userAgeDays + (userAgeYears / 4);
   
    //Assign Values
   
    //Outputting Values
   Console.WriteLine("You are " + userAgeDays + " days old.\n");
  
   // 24 hours/day, 60 minutes/hour
   userAgeMinutes = userAgeDays * 24 * 60;
   Console.WriteLine("You are " + userAgeMinutes + " minutes old.\n");
   avgBeatsPerMinute = 72;
   totalHeartbeats = userAgeMinutes * avgBeatsPerMinute;
   Console.WriteLine("Your heart has beat " + totalHeartbeats + " times.\n");
   
   
    }
 }
}
