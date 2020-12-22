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
            var summary1 = Summarytext(sentence);
            Console.WriteLine(summary1);
            var summary2 = Summarytext(sentence,60);
            Console.WriteLine(summary2);
        }

        static string Summarytext(string text,int maxlength = 20)
        { 
            if (text.Length < maxlength)
            {
                return text;
            }
        else
        {
            var words = text.Split(' ');
            var totallength = 0;
            var wordslist = new List<string>();
            foreach(var word in words)
            {
                totallength += word.Length + 1;
                wordslist.Add(word);
                if (totallength > maxlength)
                {
                    break;                       
                }
            }
            var summary =  (String.Join(" ", wordslist))+"...";
            return summary;
        }
        }

    }
}
