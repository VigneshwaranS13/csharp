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
            const int maxLength = 20;

            if (sentence.Length < 20)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totallength = 0;
                var wordslist = new List<string>();
                foreach(var word in words)
                {
                    totallength += word.Length + 1;
                    wordslist.Add(word);
                    if (totallength > maxLength)
                    {
                        break;                       
                    }
                }
                Console.WriteLine((String.Join(" ", wordslist))+"..."); 
            }
        }

    }
}
