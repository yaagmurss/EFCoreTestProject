﻿using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;


namespace DateTime
{
    class function
    {
        

        public void DateTimeOperations()
        {
            Console.Title = "---DateTime Operations---";

            //DateTime Now
            System.DateTime dateTimeVariable = new System.DateTime();
            dateTimeVariable = System.DateTime.Now;
            Console.WriteLine("Current Date and Time is : " + dateTimeVariable);

            //DateTime Day            
            Console.WriteLine("Today is {0}. day of the month", dateTimeVariable.Day);

            //DateTime DayOfWeek            
            Console.WriteLine("Today is {0}", dateTimeVariable.DayOfWeek);

            //DateTime DayOfYear            
            Console.WriteLine("Today is {0}. day of year", dateTimeVariable.DayOfYear);

            //DateTime Hour            
            Console.WriteLine("Current Hour is {0}", dateTimeVariable.Hour);

            //DateTime Minute            
            Console.WriteLine("Current Second is {0}", dateTimeVariable.Minute);

            Console.WriteLine("----------------------------------------------------------------------");

            //DateTime.Add TimeSpan
            System.DateTime dt = new System.DateTime();
            dt = System.DateTime.Now;            

            TimeSpan ts = new TimeSpan(1, 0, 0);
            Console.WriteLine("Current hour is : {0} After adding 1 hour new hour is : {1}", dt.Hour, dt.Add(ts).Hour);

            //DateTime.AddDays
            var extraDay = 5;
            Console.WriteLine("Current Day is {0} After Adding 5 day new day is {1}", dt.Day, dt.AddDays(extraDay).Day);


            Console.WriteLine("----------------------------------------------------------------------");


            //DateTime.ToLongTimeString
            Console.WriteLine(dt.ToLongDateString());

            //DateTime.ToLongTimeString
            Console.WriteLine(dt.ToLongTimeString());

            //DateTime.ToShortDateString
            Console.WriteLine(dt.ToShortDateString());

            //DateTime.ToShortTimeString
            Console.WriteLine(dt.ToShortTimeString());

            Console.WriteLine("----------------------------------------------------------------------");

            //DateTime IsLeapYear
            var currentYear = dt.Year;
            if (System.DateTime.IsLeapYear(currentYear)){Console.WriteLine(currentYear + " is a LeapYear");}
            else{Console.WriteLine(currentYear + " is not a LeapYear");}

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("yyyy-MM-dd ==> " + dt.ToString("yyyy-MM-dd"));
            Console.WriteLine("yyyy-MM-dd ==> " + dt.ToString("yyyy-MM-dd"));
            Console.WriteLine("dd-MM-yyyy ==> " + dt.ToString("dd-MM-yyyy"));
            Console.WriteLine("dd.MM.yyyy ==> " + dt.ToString("dd.MM.yyyy"));
            Console.WriteLine("dddd ==> " + dt.ToString("dddd"));


            Console.WriteLine("---------------------------CultureInfo-------------------------------------------");

            Console.WriteLine(dt.ToString("f"), new System.Globalization.CultureInfo("en-US"));
            Console.WriteLine(dt.ToString("f"), new System.Globalization.CultureInfo("fr-FR"));


            //TimeSpan
        }

        public void MathematicalOperations()
        {
            //Abs(int value)
            //Gives Absolute Value
            Console.WriteLine(Math.Abs(-1));
            Console.WriteLine(Math.Abs(-9.223333));
            Console.WriteLine(Math.Abs(245));

            //Celling(double | decimal)
            //Gives Whole Number (round to bigger whole number)
            Console.WriteLine("1.1 Ceiling To ==> {0}", Math.Ceiling(1.1));
            Console.WriteLine("1.5 Ceiling To ==> {0}", Math.Ceiling(1.5));
            Console.WriteLine("1.7 Ceiling To ==> {0}", Math.Ceiling(1.7));

            //Floor(double)
            //Gives Whole Number (round to smaller whole number)
            Console.WriteLine("1.1 Floor To ==> {0}", Math.Floor(1.1));
            Console.WriteLine("1.5 Floor To ==> {0}", Math.Floor(1.5));
            Console.WriteLine("1.7 Floor To ==> {0}", Math.Floor(1.7));

            //Round(double | Float | Decimal)
            //Gives Whole Number (round to closest whole number)
            Console.WriteLine("1.1 Round To ==> {0}", Math.Round(1.1));
            Console.WriteLine("1.5 Round To ==> {0}", Math.Round(1.5));
            Console.WriteLine("1.7 Round To ==> {0}", Math.Round(1.7));

            //Round(double | Float | Decimal)
            //Gives Whole Number (round to closest whole number)
            Console.WriteLine("1.156 Round To ==> {0}", Math.Round(1.156,0));
            Console.WriteLine("1.556 Round To ==> {0}", Math.Round(1.556,1));
            Console.WriteLine("1.756 Round To ==> {0}", Math.Round(1.756,2));

            //Pow(double x, double y)
            //The first parameter is the base, the second parameter is the exponent
            Console.WriteLine("2 exponent of 2  ==> {0}", Math.Pow(2, 2));
            Console.WriteLine("2 exponent of 3  ==> {0}", Math.Pow(2, 3));
            Console.WriteLine("5 exponent of 2  ==> {0}", Math.Pow(5, 2));

            //Sqrt(double)
            //Gives sqrt of value
            Console.WriteLine("Sqrt of 81  ==> {0}", Math.Sqrt(81));

            //DivRem(int a, int b, out int k)
            //The first parameter is the divide, the second parameter is the divisor, third parameter is remaining
            
            Console.WriteLine("10 divide 3 = {0} Remaining is = {1}", Math.DivRem(10, 3, out var k) , k.ToString());

            //Sign(int)
            //Returns 0 or 1 or -1 according to sign of integer
            Console.WriteLine("Sign(-5) ==> {0}", Math.Sign(-5));
            Console.WriteLine("Sign(5) ==> {0}", Math.Sign(5));
            Console.WriteLine("Sign(0) ==> {0}", Math.Sign(0));








        }

        enum Gender
        {
            man,
            woman
        }
        enum Aylar
        { 
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        enum jobs 
        {
            Engineer = 1,
            Doctor = 2,
            Architect = 3,
            Lawyer = 4 
        }
        public void Enumeration()
        {
            //Enum is a short way of enumaration
            Console.WriteLine("My Gender is {0} ", Gender.woman);
            Console.WriteLine("Third month of the year is {0} ", (Aylar)3);

            //Enumaration start with 0
            //If you are not enumarate anything in an enum It is going to enumarate by itself anyway
            Console.WriteLine("My Gender is {0} ", (Gender)1);
            Console.WriteLine("First month of the year is {0} ", (Aylar)1);

            //GetName(Type enum, object value)
            Console.WriteLine("My job is {0}",Enum.GetName(typeof(jobs), 1));
            Console.WriteLine("My job is {0}", Enum.GetName(typeof(jobs), 4));
            Console.WriteLine("All Jobs");
            string[] jobs = Enum.GetNames(typeof(jobs));
            foreach (string m in jobs) Console.WriteLine(m);

           

        }
        public void Arrays()
        {
            //Arrays stores in memory in a sequence (They have dimensions and a certain capacity)
            //They are readable and changeable
            //Member of an array is constant 
            //If you try to add a new element in a array that has no space for a new item, It is going to be a error
            //They can store single type of value

            //One Dimensional Arrays veriTipi[] arrayName = new variableType[number of array]
            Console.Title = "Arrays";
            string[] pdlanguage = new string[10];

            pdlanguage[0] = "c#";
            pdlanguage[1] = "Java";
            pdlanguage[2] = "c";
            pdlanguage[3] = "delphi";

            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            int[] number = new int[8]{0, 1, 2, 3, 4, 5, 6, 7,};

            //class presence is constant
            Console.Write("Please enter the class presence : ");
            int classPresence = Convert.ToInt32(Console.ReadLine());

            string[] studentName = new string[classPresence];            
            int[] scores = { 45, 55, 65 };            

            for(int i=0; i<=classPresence-1; i++)
            {
                Console.Write("{0}. Students name  : ",i);
                studentName[i] = Console.ReadLine();

            }
            Console.WriteLine("---------------------------------------------------------------");

            for (int i = 0; i <= scores.Length - 1; i++)
            {
                Console.WriteLine("{0}'s grade is {1}", studentName[i], scores[i]);

            }

            Console.WriteLine("---------------------------------------------------------------");

            string[] departure = { "Software", "HR", "Finance" };
            Console.WriteLine("Departure that i work is {0}",departure[0]);

            double[] grades = new double[3] {55.5, 56.5, 65.5};
            Console.WriteLine("Grade that i got is {0}", grades[1]);

            Console.WriteLine("---------------------------------------------------------------");

            
            string[] person = { "yagmur", "burak", "aysel", "mustafa", "yasar", "ebru" };
            //If you want to produce random number in order to find who is gonna win 
            //You need to produce a random number between arrays start and end index

            Random rnd = new Random();
            int line = rnd.Next(0, person.Length + 1);
            Console.WriteLine("Luck person is {0}", person[line]);

            //Lenght returns number of elements that array has
            Console.WriteLine("array of person length is {0}", person.Length);

            //Rank returns size of the array
            Console.WriteLine("array of person rank is {0}", person.Rank);

        }
        public void deneme()
        {
            XDocument doc = XDocument.Load("C:/Users/200741/Desktop/Response_type3.xml");
            XNamespace ns3 = "http://isbank.com/FinancialMgmt/CustCreditDecisioning/CMAFinancialsIntegration/Service/V1";
            XNamespace ns2 = "http://isbank.com/FinancialMgmt/CustCreditDecisioning/Schema/KYPSharedTypes/V1";
            decimal b = 0.0m;

            List<string> list = new List<string> { "331", "431", "500", "501" };

            foreach (var element in list)
            {
                var query = (from node in doc.Descendants(ns3 + "mizanRawDataList")
                             where node.Element(ns3 + "accountParentCode").Value == element
                             select node).ToList();
                foreach (var q in query)
                {

                    switch (element)
                    {
                        case "331":                            
                            if (q.Element(ns3 + "accountLevel").Value == "1") {b = Math.Round(Convert.ToDecimal(q.Element(ns3 + "balanceClaim").Value));}
                            break;
                        case "431":
                            if (q.Element(ns3 + "accountLevel").Value == "1") { b = Math.Round(Convert.ToDecimal(q.Element(ns3 + "balanceClaim").Value)); }
                            break;
                        case "500":
                            if (q.Element(ns3 + "accountLevel").Value == "1") { b = Math.Round(Convert.ToDecimal(q.Element(ns3 + "balanceClaim").Value)); }
                            break;
                        case "501":
                            if (q.Element(ns3 + "accountLevel").Value == "1") { b = Math.Round(Convert.ToDecimal(q.Element(ns3 + "balanceDept").Value)); }
                            break;

                    }
                }


            }
        }
        public void MultiDimensionalArrays()
        {
            //One dimensional Arrays have one row but multiple column
            //Multidimensional Arrays have multiple rows and multiple column (x, y coordinates)

            Console.Title = "MultiDimensionalArrays";

            Console.WriteLine("----------------------------Matrix Arrays-----------------------------------");

            //Number of elements vertically and horizontally is constant
            //We can think about Matrix as a table that has multiple rows and columns
            // dataType[,] arrayName = new dataType[row, column] 
            // string[,] array = new string[3,2] ==> has three rows  and two columns
            // array[0][0] ==> first row and first column
            // array[0][1] ==> first row and second column
            // array[2][1] ==> third row and second column
            // array[0,0] = "Furkan" adds variable into the arrays (first row and first column)
            double[,] table1 = new double[2, 2];
            table1[0, 0] = 55;
            table1[0, 1] = 56;
            table1[1, 0] = 57;
            table1[1, 1] = 58;
            
            double[,] table2 = { { 55, 56 }, { 57, 58 } };

            Console.WriteLine("----------------------------Jagged Arrays-----------------------------------");

            //If every elemen of array act like different array It calls jaggedArrays
            //dataType[][] arrayName = new dataType[capacity][];

            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3];

            string[][] jarray = new string[2][];
            jarray[0] = new string[2];
            jarray[0][0] = "Ali";
            jarray[0][1] = "Veli";





        }


    }
}
