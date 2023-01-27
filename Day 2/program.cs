Print the sum of digits

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int  n,sum=0,m;         
       Console.Write("Enter a number: ");      
       n= int.Parse(Console.ReadLine());     
       while(n>0)      
       {      
        m=n%10;      
        sum=sum+m;      
        n=n/10;      
       }      
       Console.Write("Sum is= "+sum);  
    }
}
----------------------------------------------------------------------------------------------------------------------------

Swap two numbers

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number : ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3=0;
        
        n3=n1;
        n1=n2;
        n2=n3;
        
        Console.WriteLine("After swapping");
        Console.WriteLine("New value of n1 is : " + n1);
        Console.WriteLine("New value of n2 is : " + n2);
    }
}
------------------------------------------------------------------------------------------------------------------------------------

To check whether the input alphabet is vowel or not using switch case

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the alphabet : ");
        char ch=Convert.ToChar(Console.ReadLine());
        
        switch (ch)
        {
            case 'a':
            Console.WriteLine("It is a vowel");
            break;
            case 'e':
            Console.WriteLine("It is a vowel");
            break;
            case 'i':
            Console.WriteLine("It is a vowel");
            break;
            case 'o':
            Console.WriteLine("It is a vowel");
            break;
            case 'u':
            Console.WriteLine("It is a vowel");
            break;
            default:
            Console.WriteLine("Not a vowel");
            break;
        }
    }
}
--------------------------------------------------------------------------------------------------------------------------------------------

To check if the number is palindrome or not

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num, rem, sum = 0, temp;  
        Console.Write("Enter a number: ");  
        num = Convert.ToInt32(Console.ReadLine());  
        temp = num;  
        while (num > 0) {  
            rem = num % 10;     
            num = num / 10;     
            sum = sum * 10 + rem;  
        }  
        Console.WriteLine("The Reversed Number is: " + sum);  
        if (temp == sum)  
        {  
            Console.WriteLine("Number is Palindrome");  
        } 
        else 
        {  
            Console.WriteLine("Number is not a palindrome");  
        }  
    }
}--------------------------------------------------------------------------------------------------------------------------------------------------
