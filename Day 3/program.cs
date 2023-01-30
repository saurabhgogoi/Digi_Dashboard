To check whether the number is odd or even

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if(n%2==0)
        {
            Console.WriteLine("It is an even number");
        }
        else
        {
            Console.WriteLine("It is an odd number");
        }
    }
}
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

To check whether the year is leap year or not

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the year : ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if(((n%4==0) && (n%100!=0)) || (n%400==0))
        {
            Console.WriteLine("It is a leap year");
        }
        else
        {
            Console.WriteLine("It is not a leap year");
        }
    }
}
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

In this method, get inputs such as driving license, ID proof, and passport from the teens and store it in variables. Then use if-else conditional statement to print the right message.
The teenager must have driving license and either ID proof or passport.
If the teenager has driving license and either ID proof or passport then print No ticket issued. Else if print Ticket issued.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofValidations 
{
    public class Program 
	{
        public static void Main(string[] args)  
        {
            Console.WriteLine("Driving License:");
            string license = Console.ReadLine();

            Console.WriteLine("ID Proof:");
            string id = Console.ReadLine();

            Console.WriteLine("Passport:");
            string passport = Console.ReadLine();

            if (license == "Available" && (id == "Available" || passport == "Available"))
                {
			Console.WriteLine("No ticket issued");
		}
            else
                {
			Console.WriteLine("Ticket issued");
		}
        }
    }
}
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
