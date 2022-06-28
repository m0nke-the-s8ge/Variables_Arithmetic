using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    float milesTraveled;
    float hoursToFly;
    float hoursToDrive;
  
   
    //Assign Values
    milesTraveled = 400.5f;
   
    // Plane fly 500 MPH
    hoursToFly = milesTraveled / 500.0f;
   
    //Car drives 60 MPH
    hoursToDrive = milesTraveled / 60.0f;
   
 
    //Outputting Values
   Console.WriteLine(milesTraveled + " hours to fly or\n");
   Console.WriteLine(hoursToFly + " hours to fly or\n");
   Console.WriteLine(hoursToDrive + " hours to drive.");
   
   
    }
 }
}
