using System;

namespace DateTime
{



    class Person
    {
        public string Name;
        public void Introduce(string str)
        {
            Console.WriteLine("Hi {0} ! My name is {1}", str, Name);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            function fn = new function();

            //fn.DateTimeOperations();
            //fn.MathematicalOperations();
            //fn.Enumeration();
            //fn.Arrays();
            //fn.deneme();
            //fn.MultiDimensionalArrays();
            //fn.ArrayClass();
            //fn.Collections();
            //fn.Methods();
            //fn.RecursiveMethds(5);
            //fn.Classes();

            var customer = new Customer();
            Console.WriteLine("Customer id is : {0} Customer names is {1} ", customer.Id, customer.Name);



            Console.ReadLine();
        }   


    }
}


