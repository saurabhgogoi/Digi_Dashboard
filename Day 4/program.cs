In this method, you should get a character input from the user. According to the input display the output. Consider below table for more understanding. Marks given in table are inclusive.
Other than(A-F) grade is given as input then print "Invalid grade".
Use switch case. Display the Marks as string datatype -- "50-60"

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter your grade: ");
        char ch = Convert.ToChar(Console.ReadLine());
        
        switch (ch)
        {
            case 'A':
            Console.WriteLine("90-100");
            break;
            case 'B':
            Console.WriteLine("80-90");
            break;
            case 'C':
            Console.WriteLine("70-80");
            break;
            case 'D':
            Console.WriteLine("60-70");
            break;
            case 'E':
            Console.WriteLine("50-60");
            break;
            case 'F':
            Console.WriteLine("<50");
            break;
            default:
            Console.WriteLine("Invalid input");
            break;
        }
    }
}
-----------------------------------------------------------------------------------------------------------

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
            //Implement your code here
            Console.WriteLine("Driving License:");
            string license = Console.ReadLine();

            Console.WriteLine("ID Proof:");
            string id = Console.ReadLine();

            Console.WriteLine("Passport:");
            string passport = Console.ReadLine();

            if (license == "Available" && (id == "Available" || passport == "Available"))
                Console.WriteLine("No ticket issued");
            else
                Console.WriteLine("Ticket issued");

            Console.ReadLine();
        }
    }
}
----------------------------------------------------------------------------------------------------------

Using break statement

using System;  
public class BreakExample  
    {  
      public static void Main(string[] args)  
      {  
          for (int i = 1; i <= 10; i++)  
          {  
              if (i == 5)  
              {  
                  break;  
              }  
              Console.WriteLine(i);  
          }  
      }  
   }  
-------------------------------------------------------------------------------------------------------

Using continue statement

using System;  
public class ContinueExample  
    {  
      public static void Main(string[] args)  
      {  
         for(int i=1;i<=10;i++){    
            if(i==5){    
                continue;    
            }    
            Console.WriteLine(i);    
        }    
      }  
   }  
-------------------------------------------------------------------------------------------------------
