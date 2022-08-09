using System;


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
    }
}
