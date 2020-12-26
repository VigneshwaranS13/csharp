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

            //String validation

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid Entry");
            }
            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid Entry");
            }
            if (String.IsNullOrEmpty(" ")) // eventhough its empty it will not be considered as empty so it will not go to next step
            {
                Console.WriteLine("Invalid Entry");
            }
            if (String.IsNullOrEmpty(" ".Trim())) // we can get rid of above issue by this steps
            {
                Console.WriteLine("Invalid Entry");
            }
            if(String.IsNullOrWhiteSpace(" ")) // microsoft introduced this new mehtod which will check whether the string is empty,null or it having whitespaces
            {
                Console.WriteLine("Invalid entry");
            }

            //  string to number 

            var age = "25";

            var Age = Convert.ToByte(age);
            Console.WriteLine("Age is " + Age);

            // number to string

            float price = 30.56f;
            Console.WriteLine(price.ToString("C0"));// it will convert the string to currenct format and round it to one decimal i.e 31


        }

    }
}
