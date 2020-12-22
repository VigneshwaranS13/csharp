using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class SummaryText
    {

        public static string Summarytext(string text, int maxlength = 20)
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
                foreach (var word in words)
                {
                    totallength += word.Length + 1;
                    wordslist.Add(word);
                    if (totallength > maxlength)
                    {
                        break;
                    }
                }
                var summary = (String.Join(" ", wordslist)) + "...";
                return summary;
            }
        }
    }
}
