using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CybersecurityChatbot
{

    public class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Greetings.wav");
                player.PlaySync(); // waits until finished
            }
            catch (Exception)
            {
                Console.WriteLine("⚠️ Could not play voice greeting.");
            }
        }
    }
}

