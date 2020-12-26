using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    
    public enum ShippingMethod 
    { 
        RegularMail =1,
        Registered =2,
        Express =3
    }
    public enum ShippingMethod2
    {
        RegularMail,// by default it will asssign value 0 for the first member and will automatically increment by 1
        Registered,
        Express
    }
    public enum ShippingMethod3 : byte
    {
        RegularMail,// by default it will asssign value 0 for the first member and will automatically increment by 1
        Registered,
        Express
    }
    class Program
    {   
        
        static void Main(string[] args)
        {

            var method = ShippingMethod.Express;
            Console.WriteLine((int)(method));// 3
            Console.WriteLine(method);// Express

            var methodID = 2;
            Console.WriteLine((ShippingMethod)(methodID)); // Express

            var method2 = ShippingMethod2.Express;
            var method3 = ShippingMethod2.Registered;
            var method4 = ShippingMethod2.RegularMail;
            Console.WriteLine((int)method2);//2
            Console.WriteLine((int)method3);//1
            Console.WriteLine((int)method4);//0
            Console.WriteLine(method2.GetType());//CSharpFundamentals.ShippingMethod2

            var method5 = ShippingMethod3.Express;
            var method6 = ShippingMethod3.Registered;
            var method7 = ShippingMethod3.RegularMail;
            Console.WriteLine((byte)method5);//2
            Console.WriteLine((byte)method6);//1
            Console.WriteLine((byte)method7);//0
            Console.WriteLine(method5.GetType());//CSharpFundamentals.ShippingMethod3

            Console.WriteLine(method2.ToString());//console.writeline will automatically convert the var to string

            var methodName = "Registered";
            var enumconvertedvar = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(enumconvertedvar);//Registered
            Console.WriteLine(enumconvertedvar.GetType());//CSharpFundamentals.ShippingMethod




        }
    }
}
