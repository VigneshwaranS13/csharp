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
            // exercise 1
            //Console.WriteLine("Enter interger bw 1 -10 :");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 1 && number <= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            // exercise2
            //Console.WriteLine("Enter number 1 :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number 2 :");            
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine(string.Format("bigger nubmer is {0}",a));
            //}
            //else if (b >a)
            //{
            //    Console.WriteLine(string.Format("bigger no is {0}",b));
            //}
            //else
            //{
            //    Console.WriteLine("both the numbers are same");
            //}
            // exercise 3
            //Console.WriteLine("Enter the length of the image : ");
            //float length = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Enter the width of an image : ");
            //float width = Convert.ToSingle(Console.ReadLine());

            //if (length > width)
            //{
            //    Console.WriteLine("the image is portrait");
            //}
            //else if (width > length)
            //{
            //    Console.WriteLine("the image is landscape");
            //}
            //else
            //{
            //    Console.WriteLine("image is not portrait nor landscape");
            //}
            //exercise4
            Console.WriteLine("Enter the speed limit of the camera");
            float cameraspeed = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car ");
            float carspeed = Convert.ToSingle(Console.ReadLine());
            
            if (carspeed <= cameraspeed)
            {
                Console.WriteLine("ok");
            }
            else if((carspeed -cameraspeed) >= 5 && (carspeed -cameraspeed) <10)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 10 && (carspeed - cameraspeed) < 15)
            {
                Console.WriteLine("you are getting demeritted by 2 point,still 10 points you have");
            }
            else if ((carspeed - cameraspeed) >=15 && (carspeed - cameraspeed) < 20)
            {
                Console.WriteLine("you are getting demeritted by 3 point,still 10 points you have");
            }
            else if ((carspeed - cameraspeed) >= 25 && (carspeed - cameraspeed) < 30)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 30 && (carspeed - cameraspeed) <35)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 5 && (carspeed - cameraspeed) <= 6)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 5 && (carspeed - cameraspeed) <= 6)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 5 && (carspeed - cameraspeed) <= 6)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 5 && (carspeed - cameraspeed) <= 6)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else if ((carspeed - cameraspeed) >= 5 && (carspeed - cameraspeed) <= 6)
            {
                Console.WriteLine("you are getting demeritted by 1 point,still 11 points you have");
            }
            else
            {
                Console.WriteLine("License Suspended");
            }

        }
    }
}
