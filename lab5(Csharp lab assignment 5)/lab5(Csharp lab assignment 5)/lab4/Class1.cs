using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Class1
    {
        private static  List<Class1> product = new List<Class1>();

        public string number { get; set;}
        public string inventory { get; set;}
        public string objectname { get; set;}
        public string count { get; set;}
        public string price { get; set;}

        public void save()
        {
            product.Add(this);
           
           // Console.WriteLine("saved");
        }
        public static  List<Class1> getall()
        {
            return product;
            // we exe select statement
        }
            



    }
}
