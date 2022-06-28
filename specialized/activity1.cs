using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    //Declare Variables
    int downPayment;
    int paymentPerMonth;
    int numMonths;
    int totalCost;
    
    //Assign Value
     downPayment= 500 ;
    paymentPerMonth = 300;
    numMonths =  60;
    totalCost = downPayment + (paymentPerMonth * numMonths);
    
    Console.WriteLine("Total cost.");
    
    Console.WriteLine(totalCost);
    
    }
  }
}