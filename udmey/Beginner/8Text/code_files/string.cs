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
            var fullname = "Arya Stark ";
            Console.WriteLine("Actual Name :"+fullname);
            Console.WriteLine("Trim :'{0}' ",fullname.Trim());
            Console.WriteLine("ToUpper :'{0}' ",(fullname.Trim()).ToUpper());

            var index = fullname.IndexOf(' ');
            //Console.WriteLine(index);
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index +1);
            Console.WriteLine("FirstName : " + firstname); 
            Console.WriteLine("LastName : " + lastname);

            var names = fullname.Split(' ');
            Console.WriteLine("FirstName : " + names[0]);
            Console.WriteLine("LastName : " + names[1]);

            Console.WriteLine(fullname.Replace("Arya" ,"arya"));



        }

    }
}
