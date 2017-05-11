using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook_1_0_1.Managers
{
    public static class MusicManagers
    {
        public static void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "sounds/click3.wav";
            player.Load();
            player.Play();
        }
        public static void playBookSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "sounds/book1.wav";
            player.Load();
            player.Play();
        }
        public static void playResultSound(string file)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "sounds/" + file;
            player.Load();
            player.Play();
        }
    }
}
