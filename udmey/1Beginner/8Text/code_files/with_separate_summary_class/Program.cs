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
            var sentence = " We can easily summarize the long text by following below steps and can implement the same in our code";
            var summary1 = SummaryText.Summarytext(sentence);
            Console.WriteLine(summary1);
            var summary2 = SummaryText.Summarytext(sentence, 70);
            Console.WriteLine(summary2);
        }


    }
}
