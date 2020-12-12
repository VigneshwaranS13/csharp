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
            int hour = 18;
            // using if else
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }
            

            bool IsGoldCustomer = true;

            //float price;

            //if (IsGoldCustomer)
            //{
            //    price = 10.58f;
            //    Console.WriteLine(price);
            //}
            //else
            //{
            //    price = 8.58f;
            //    Console.WriteLine(price);
            //}

            // using conditional operator
            float price2 = (IsGoldCustomer) ? 10.58f : 8.58f;
            Console.WriteLine(price2);
                        
            
        }
    }
}
