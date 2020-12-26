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

            var season = Season.Spring;
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn season");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter season");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its summer season");
                    break;
                default:
                    Console.WriteLine("It's Spring :) ");
                    break;
            }

            // in case if we want the same op for two cases

            var season2 = Season.Winter;
            switch (season2)
            {
                case Season.Autumn:                    
                case Season.Winter:
                // this will act like a or operator
                    Console.WriteLine("It's either autmn or winter season,enjoy");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its summer season");
                    break;
                default:
                    Console.WriteLine("It's Spring :) ");
                    break;
            }
        }
    }
}
