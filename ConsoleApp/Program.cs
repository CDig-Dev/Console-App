using System.Collections.Concurrent;
using System.Globalization;

namespace ConsoleApp;

class Program
{
   // public static double CalculateAreaCircle (double radius)
   // {
     //   return Math.PI * radius * radius;
    //}

   // static void Main(string[] args)
 //  {
     //   Console.WriteLine("Enter the radius of the circle:");
       // double radius = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine($"The area is {CalculateAreaCircle(radius)}");
        
   // }

 //  public static double CalculateAreaTriangle(double baseLength, double height)
   //{
     //  return 0.5 * baseLength * height;
   //}

   //static void Main(string[] args)
   //{
     //  Console.WriteLine("Enter the base length of the triangle:");
       //double baseLength = Convert.ToDouble(Console.ReadLine());
       //Console.WriteLine("Enter the height of the triangle:");
       //double height = Convert.ToDouble(Console.ReadLine());
       //Console.WriteLine($"The Area of the Triangle is {CalculateAreaTriangle(baseLength, height)}");


    //   public static double CalculateAreaRectangle(double width, double length)
      // {
        // return width * length;
       //}

       //static void Main(string[] args)
       //{
        // Console.WriteLine("Enter the length of the rectangle");
         //double length = Convert.ToDouble(Console.ReadLine());

         //Console.WriteLine("Enter the width of the rectangle");
         //double width = Convert.ToDouble(Console.ReadLine());
         //Console.WriteLine($"The area of the rectangle is {CalculateAreaRectangle(length, width)}");
       //}
       public static double CalculateAreaSquare(double side)
       {
         return side * side;
       }

       static void Main(string[] args)
       {
         Console.WriteLine("Enter the side length of the square:");
         double side = Convert.ToDouble(Console.ReadLine());
         
         double area = CalculateAreaSquare(side);
         Console.WriteLine($"The area of the Square is {side * side}");
       }

}