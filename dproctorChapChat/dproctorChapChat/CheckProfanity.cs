using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace dproctorChapChat
{
    class CheckProfanity
    {
        public String ProfanityChecker(string text)
        {
            
            string[] textArray = text.Split(' ');
            string[] profanity = { "[$s]h[!i]t", "fuck", "b[!i]tch", "d[@a]mn" };
            string comRex = string.Join("|", profanity);

            comRex = @"(" + comRex + @")";           

            text = Regex.Replace(text, comRex, "****", RegexOptions.IgnoreCase);

            return text;
        }
    }
}
