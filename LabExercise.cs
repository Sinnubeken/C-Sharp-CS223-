using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    interface Shape{
       double area { get; set; }
       double perimeter { get; set; }

    }

    public class Circle : Shape
    {
        public double area { get; set;}
        public double perimeter { get; set; }

       
    }

    public class Square : Shape
    {
        public double area { get; set; }
        public double perimeter { get; set; }

    }
    public class Triangle : Shape
    {
        public double area { get; set; }
        public double perimeter { get; set; }

    }




internal class Program
{
    static void Main(string[] args)
    {
         Shape s;
         double r;
         double pi = 3.1;
         double side;
         double height;
         double b;
            
            double sideA;
            double sideB;
            double sideC;


            Console.WriteLine("Enter radius of the circle:");
         r=double.Parse(Console.ReadLine());
            s = new Circle { area = pi*r* r , perimeter = 2 * pi * r };
       
         Console.WriteLine("Area of the circle: "+s.area);
         Console.WriteLine("Perimeterr of cicle: "+s.perimeter);
         Console.ReadKey();
         Console.WriteLine("\nEnter sides for square:");
         side = double.Parse(Console.ReadLine());
         s = new Square { area =side*side, perimeter = side+side+side+side };
         Console.WriteLine("Area of the square: " + s.area);
         Console.WriteLine("parameter of square: " + s.perimeter);
         Console.ReadKey();
         Console.WriteLine("\nEnter base for triangle:");
         b = double.Parse(Console.ReadLine());
         Console.WriteLine("\nEnter height for triangle:");
         height = double.Parse(Console.ReadLine());
         Console.WriteLine("\nEnter side A for triangle:");
         sideA=double.Parse(Console.ReadLine());
         Console.WriteLine("\nEnter side B for triangle:");
         sideB = double.Parse(Console.ReadLine());
         Console.WriteLine("\nEnter side C for triangle:");
         sideC = double.Parse(Console.ReadLine());
         s = new Square { area = 0.5*b*height, perimeter = sideA + sideB + sideC };
         Console.WriteLine("Area of the triangle: " + s.area);
         Console.WriteLine("perimeter of triangle: " + s.perimeter);
         Console.ReadKey();





        }
}
}
/*
    //partial class Form { // there are two kinds sys gen and user gen
      //  }
    class baseclass {
        protected double name2;
    }
    class employee : baseclass // inheritance in c#
    {
        private double salary;
        private string employeeid;
        private string name;
        private int age;
       
        
        public string _name
        {
            get => name; // its called a property its used to reduce code on get and set
            set => name = value;//>>>  >>>>>
        }
    // internal int id; //only acccessed  if its in the same assembly
   // public string name { get; set; }
   // 
        public int _age
        {
            get => age;
            set => age = value;
        }
        public double _salary
       {
               get => salary;
               set => salary = Value;
       }
     private string _employeeid
        {
            get => employeeid;
            set => employeeid = value;
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         employee e =  new employee();
            e._salary = 1;
            Console.WriteLine(e._salary);
            
        }
    }
}
*/