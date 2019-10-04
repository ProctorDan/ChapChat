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
        public static String ProfanityChecker(string text)
        {
            
            string[] textArray = text.Split(' ');
            string[] profanity = { "shit", "fuck", "bitch", "damn", "damnit" };
            string comRex = string.Join("|", profanity);
            comRex = @"\b(" + comRex + @")\b(\w+|\s)";
            
            text = Regex.Replace(text, comRex, "****", RegexOptions.IgnoreCase);

            return text;
        }
    }
}
