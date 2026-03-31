using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm just a bot, but I'm running perfectly! 🤖";

            else if (input.Contains("purpose"))
                return "My purpose is to educate you about cybersecurity.";

            else if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols.";

            else if (input.Contains("phishing"))
                return "Be careful of suspicious emails asking for personal info.";

            else if (input.Contains("safe browsing"))
                return "Always check URLs and avoid clicking unknown links.";

            else if (input.Contains("what can i ask"))
                return "You can ask me about passwords, phishing, and online safety.";

            else
                return "❓ I didn't quite understand that. Could you rephrase?";
        }
    }
}