using System;
 
namespace MyApplication
{
 class Program
 {
   static void Main(string[] args)
   {
   
    //Declare Variables
    float gasVolume;
    float oilVolume;
    float mixRatio;
  
   
    //Assign Values
    gasVolume = 10.5f;
    oilVolume = 0.0f;
   
    mixRatio = gasVolume / oilVolume;
 
    //Outputting Values
   Console.WriteLine("Gas to oil mix ratio is " + mixRatio + ":1\n");
   
   
    }
 }
}
