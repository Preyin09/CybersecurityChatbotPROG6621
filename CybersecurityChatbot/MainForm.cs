using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace CybersecurityChatbot
{
    public partial class MainForm : Form
    {
        private string favouriteTopic = "";
        private string lastTopic = "";

        Random random = new Random();

        List<string> phishingTips = new List<string>()
        {
            "Never click suspicious links in emails.",
            "Verify email senders carefully.",
            "Avoid downloading unknown attachments.",
            "Scammers often pretend to be trusted organisations."
        };

        Dictionary<string, string> keywordResponses =
            new Dictionary<string, string>()
        {
            {"password", "Use strong passwords with symbols and numbers."},
            {"privacy", "Review your privacy settings regularly."},
            {"scam", "Be careful of fake websites and online scams."},
            {"safe browsing", "Only visit secure HTTPS websites."}
        };

        public delegate string ResponseDelegate(string input);

        public MainForm()
        {
            InitializeComponent();

            // 🔊 Voice Greeting
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Play();
            }
            catch
            {
                MessageBox.Show("Could not play greeting audio.");
            }

            richTextBoxChat.AppendText(
                "🔐 CYBERSECURITY AWARENESS BOT 🔐\n");
            richTextBoxChat.AppendText(
                "Bot: Hello! Ask me about cybersecurity.\n\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = textBoxUserInput.Text.Trim();

            // Empty Input
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            // Show User Message
            richTextBoxChat.AppendText(
                "You: " + userInput + "\n");

            // Delegate
            ResponseDelegate chatbot = GetResponse;

            string response = chatbot(userInput);

            // Show Bot Response
            richTextBoxChat.AppendText(
                "Bot: " + response + "\n\n");

            // Clear TextBox
            textBoxUserInput.Clear();
        }

        private string GetResponse(string input)
        {
            input = input.ToLower();

            // 😊 Sentiment Detection
            if (input.Contains("worried"))
            {
                return "It's understandable to feel worried. Never share passwords or OTPs online.";
            }

            if (input.Contains("frustrated"))
            {
                return "Cybersecurity can feel overwhelming, but small habits help keep you safe.";
            }

            if (input.Contains("curious"))
            {
                return "Learning cybersecurity is a great way to stay safe online.";
            }

            // 🧠 Memory Feature
            if (input.Contains("i like"))
            {
                if (input.Contains("privacy"))
                {
                    favouriteTopic = "privacy";
                    return "Great! I'll remember that you're interested in privacy.";
                }

                if (input.Contains("password"))
                {
                    favouriteTopic = "password safety";
                    return "Awesome! I'll remember your interest in password safety.";
                }
            }

            // 🔄 Recall Memory
            if (input.Contains("what do i like"))
            {
                if (!string.IsNullOrEmpty(favouriteTopic))
                {
                    return $"You told me you're interested in {favouriteTopic}.";
                }

                return "You haven't told me your favourite topic yet.";
            }

            // 🔑 Keyword Recognition
            foreach (var keyword in keywordResponses)
            {
                if (input.Contains(keyword.Key))
                {
                    lastTopic = keyword.Key;
                    return keyword.Value;
                }
            }

            // 🎲 Random Responses
            if (input.Contains("phishing"))
            {
                lastTopic = "phishing";

                return phishingTips[random.Next(phishingTips.Count)];
            }

            // 🔄 Conversation Flow
            if (input.Contains("tell me more") ||
                input.Contains("another tip") ||
                input.Contains("explain more"))
            {
                if (lastTopic == "phishing")
                {
                    return "Phishing scams often pretend to be banks or trusted companies.";
                }

                if (lastTopic == "privacy")
                {
                    return "Avoid sharing personal information publicly online.";
                }

                if (lastTopic == "password")
                {
                    return "Strong passwords should contain uppercase letters, numbers, and symbols.";
                }

                return "Please tell me which topic you'd like more information about.";
            }

            // 💬 General Questions
            if (input.Contains("how are you"))
            {
                return "I'm functioning perfectly and ready to help! 🤖";
            }

            if (input.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity awareness.";
            }

            if (input.Contains("what can i ask"))
            {
                return "You can ask me about phishing, scams, passwords, privacy, and safe browsing.";
            }

            // ❓ Default
            return "❓ I didn't quite understand that. Could you rephrase?";
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}