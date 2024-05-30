using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面试助手
{
    class NextQuestion
    {
        public static List<String> questions = new List<String>();

        public static String lastSentence = "";
        public static int lengthNeedRemoved = 0;


        public static string getNextQuestion() {

            string result = string.Join(".\n", questions);
            if (result.Trim() != "") result += ".\n";
            result+= lastSentence.Substring(lengthNeedRemoved);
 
            return result;
           
        }

        public static void clear()
        {
            questions = new List<String>();
            lengthNeedRemoved = lastSentence.Length;
        }

        public static void onNewLine(string parsedText)
        {
            questions.Add(lastSentence.Substring(lengthNeedRemoved));
            lastSentence = parsedText;
            lengthNeedRemoved = 0;
        }
    }
}
