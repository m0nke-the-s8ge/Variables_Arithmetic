using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    int salaryPerYear;
    int daysPerYear;
    int salaryPerDay;
  
   
    //Assign Values
    salaryPerYear = 60000;
    daysPerYear = 0;
   
    // If days PerYear is 0, then divide-by-zero cause program termination
    salaryPerDay = salaryPerYear / salaryPerYear;
   
    //Outputting Values
   Console.WriteLine("Salary per day is: " + salaryPerDay);
   
   
   
    }
 }
}
