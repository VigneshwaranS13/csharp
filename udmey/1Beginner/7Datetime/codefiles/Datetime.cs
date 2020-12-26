using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals 
{ 
    
    class Program
    {

        static void Main(string[] args)
        {
            var datetime = new DateTime(); // it will initalize the date like below
            Console.WriteLine(datetime);//01-01-0001 00:00:00

            var datetime2 = new DateTime(2020, 12, 19);//it will initalize the date like below
            Console.WriteLine(datetime2);// 19-12-2020 00:00:00

            //we can directly using dateime statis methods
            var now = DateTime.Now;
            Console.WriteLine("now " +now);//now 19-12-2020 08:16:32
            var today = DateTime.Today;
            Console.WriteLine("today " + today);//today 19-12-2020 00:00:00

            // datetime variables are immutable,once we create them we can't modify but we can add values using bunch of methodsi.e.Add
            var tom = now.AddDays(1);
            var yes = now.AddDays(-1);

            // datetime object in csharp are formatting them as a string,we can use below  methods to convert datetime string

            Console.WriteLine(now.ToLongDateString());//19 December 2020
            Console.WriteLine(now.ToShortDateString());//19-12-2020
            Console.WriteLine(now.ToLongTimeString());//08:22:48
            Console.WriteLine(now.ToShortTimeString());//08:22 AM
            Console.WriteLine(now.ToString());//19 - 12 - 2020 08:24:29
            //TO string method  accept a foramt specifier
            Console.WriteLine(now.ToString("dd-MMM-yyyy HH-mm"));\\19 - Dec - 2020 08 - 26

            //search for datetime format specifier we will get lot of format specifier with examples





        }

    }
}
