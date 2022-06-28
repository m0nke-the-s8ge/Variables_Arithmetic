using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    float milesTraveled;
    float hoursToDrive;
  
   
    //Assign Values
    milesTraveled = 113.5f;
   
    // Car drives 60 MPH
    hoursToDrive = milesTraveled / 60.0f;
 
    //Outputting Values
   Console.WriteLine(Math.Round(hoursToDrive, 1));
   
   
   
    }
 }
}
