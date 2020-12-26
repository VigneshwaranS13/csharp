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
            Person vicky = new Person();
            vicky.FirstName = "vigneshwaran";
            vicky.LastName = "s";
            vicky.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
