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
            /** creating timespace objects **/
            //timespaan -which represents the length of the time

            var timespan = new TimeSpan();// i will initialize the object as 00:00:00
            Console.WriteLine(timespan);//00:00:00

            var timespan1 = new TimeSpan(1, 0, 0);//hours,min,seconds
            Console.WriteLine(timespan1);//01:00:00

            // its not readable so we can use static methods of timestap
            var timespan3 = TimeSpan.FromHours(1);
            Console.WriteLine(timespan3);//01:00:00

            // we can find out the differnces of time

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(10);
            var duration = end- start;
            Console.WriteLine(duration);//00:10:00.0019984

            /** creating timespace objects **/

            // prooperties

            Console.WriteLine("Minutes" + timespan.Minutes); // will display the min values in the timespan object
            Console.WriteLine("Total Minutes" : + timespan.TotalMinutes);// will convert entire timespan to min

            // timespan objects are immutable objects 

            Console.WriteLine("Add example " + timespan.Add(TimeSpan.FromMinutes(10)));
            Console.WriteLine("Subtract : " + timespan.Subtract(TimeSpan.FromMinutes(4))));

            //tostring
            Console.WriteLine("to string " + timespan.ToString());//by default console convert it into string if we are not using console then we can use Tostring method

            //parse
            Console.WriteLine(" parse " + TimeSpan.Parse("01:02:03"));


            //quiz
            /**
            DateTime objects are immutable, which means once they're set , they cannot be changed.
            Here, AddYears() method returns a new DateTime object but we're not storing it in any variables.
            **/
            var dateTime = new DateTime(2015, 1, 1);
            dateTime.AddYears(1);
            Console.WriteLine(dateTime.Year);
            //a)2015
            //b)2016
            //DateTime objects are immutable. So here AddYears() does not affect our original object.
        }

    }
}
