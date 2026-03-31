using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class ChatLoop
    {
        public static void Start(string userName)
        {
            string input;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠️ Please enter something.");
                    continue;
                }

                string response = Chatbot.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Bot: {response}");
                Console.ResetColor();

            } while (input.ToLower() != "exit");

            Console.WriteLine("\n👋 Goodbye! Stay safe online.");
        }
    }
}