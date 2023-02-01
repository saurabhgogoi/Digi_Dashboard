Implementing abstract methods

using System;

public class HelloWorld
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.draw();
    }
    
}
----------------------------------------------------------------------------------------------------

Implementing interface

using System;

public class HelloWorld
{
    public interface IPolygon
    {
        void area(int a,int b);
    }
    public class Rectangle:IPolygon
    {
        public void area(int a,int b)
        {
            int area=a*b;
            Console.WriteLine("The area is " + area);
        }
    }
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.area(10,20);
    }
}
-------------------------------------------------------------------------------------------------------

Method overloading

using System;

namespace MethodOverload {

  class Program {  

    void display(int a) {
      Console.WriteLine("Arguments: " + a);
    }

    void display(int a, int b) {
      Console.WriteLine("Arguments: " + a + " and " + b);
    } 
    static void Main(string[] args) {

      Program p1 = new Program();
      p1.display(100);
      p1.display(100, 200);
    }
  }
}
-----------------------------------------------------------------------------------------------------------

