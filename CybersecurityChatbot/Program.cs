using CybersecurityChatbot;
using System;
using System.Media;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Cybersecurity Awareness Bot";

        PlayVoiceGreeting();
        DisplayAsciiArt();

        string userName = GetUserName();
        WelcomeUser(userName);

        StartChat(userName);
    }

    // 🔊 Voice Greeting
    static void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch (Exception)
        {
            Console.WriteLine("⚠️ Could not play voice greeting.");
        }
    }

    // 🖼️ ASCII Art Logo
    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
   ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝ ██║   ██║██╔══██╗██╔════╝██╔══██╗
  ██║      ██║   ██║██████╔╝█████╗  ██████╔╝
  ██║      ██║   ██║██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗ ╚██████╔╝██║  ██║███████╗██║  ██║
   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝

        🔐 CYBERSECURITY AWARENESS BOT 🔐
           Stay Safe. Stay Smart.
        ");

        Console.ResetColor();
    }

    // 👤 Get User Name
    static string GetUserName()
    {
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("⚠️ Name cannot be empty. Try again: ");
            name = Console.ReadLine();
        }

        return name;
    }

    // 👋 Welcome Message
    static void WelcomeUser(string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeEffect($"\nHello {name}! Welcome to the Cybersecurity Awareness Bot.");
        TypeEffect("I'm here to help you stay safe online.\n");
        Console.ResetColor();
    }

    // 💬 Chat Loop
    static void StartChat(string userName)
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

            string response = GetResponse(input);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect("Bot: " + response);
            Console.ResetColor();

        } while (input.ToLower() != "exit");

        Console.WriteLine("\n👋 Goodbye! Stay safe online.");
    }

    // 🧠 Chatbot Logic
    static string GetResponse(string input)
    {
        input = input.ToLower();

        if (input.Contains("how are you"))
            return "I'm just a bot, but I'm working perfectly! 🤖";

        else if (input.Contains("purpose"))
            return "My purpose is to educate you about cybersecurity and keep you safe online.";

        else if (input.Contains("password"))
            return "Use strong passwords with a mix of letters, numbers, and symbols.";

        else if (input.Contains("phishing"))
            return "Phishing scams trick you into giving personal info. Always verify suspicious emails.";

        else if (input.Contains("safe browsing"))
            return "Only visit secure websites (https) and avoid clicking unknown links.";

        else if (input.Contains("what can i ask"))
            return "You can ask me about passwords, phishing, and online safety tips.";

        else
            return "❓ I didn't quite understand that. Could you rephrase?";
    }

    // ⌨️ Typing Effect
    static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }
}