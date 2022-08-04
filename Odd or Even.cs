using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
    	try{
        	char ans='y';
      		int num;
      		Console.WriteLine("Hello there."); 
      		while(ans=='Y' || ans == 'y')
      		{
      			Console.WriteLine("Enter Number: ");
        		num = int.Parse(Console.ReadLine());
        		if(num%2==0){
            			Console.WriteLine("Entered number is even");
        		}
        		else {
        			Console.WriteLine("Entered number is odd");
        		}
      		}
		If(ans=='Y' || ans == 'y')
			Console.WriteLine("Thank you for using");
  
     	}
     catch (Exception ex)
	 {
        	Console.WriteLine("ERROR OCCURED");
	 }
      
    }
  }
}