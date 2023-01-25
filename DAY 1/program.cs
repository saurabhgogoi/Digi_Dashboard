USING FOR LOOP TO PRINT NEXT 10 NUMBERS

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the number");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum;
        
        for(int i = 1; i<=10; i++)
        {
            sum = n + i;
            Console.WriteLine(sum);
        }
    }
}

-----------------------------------------------------------------------------------------------------------------------------------------------------------

Write a program to print the number of times of messages given by user input

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         Console.WriteLine("Enter the Number for Repetition:");
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the message:");
            string message = Console.ReadLine();

            for(int i=1 ; i<= Num ; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
--------------------------------------------------------------------------------------------------------------------------------------------------------------

MULTIPLICATION TABLE

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the number");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i=0; i<=10; i++)
        {
            Console.WriteLine(n*i);
        }
    }
}
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

