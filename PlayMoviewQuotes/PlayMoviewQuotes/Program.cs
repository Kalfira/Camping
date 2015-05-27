using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            Random rnd = new Random();
            string entry;
            int num;
            do
            {
                num = rnd.Next(0, 3);
                if (num == 0)
                {
                    result = "http://www.wavsource.com/snds_2015-05-24_3842437052126496/video_games/duke/holy_sh.wav";
                }
                else if (num == 1)
                {
                    result = "http://www.wavsource.com/snds_2015-05-24_3842437052126496/video_games/duke/bitchin.wav";
                }
                else if (num == 2)
                {
                    result = "http://www.wavsource.com/snds_2015-05-24_3842437052126496/video_games/duke/good2.wav";
                }
                else
                {
                    result = "http://www.wavsource.com/snds_2015-05-24_3842437052126496/video_games/duke/damn.wav";
                }
                SoundPlayer sound = new SoundPlayer(result);
                sound.Play();
                Console.WriteLine("Quit? (N)");
                entry = Console.ReadLine().ToUpper();
                Console.Clear();
            } while (entry != "N");
            SoundPlayer end = new SoundPlayer("http://www.wavsource.com/snds_2015-05-24_3842437052126496/video_games/duke/terminated.wav");
            end.Play();
            Console.WriteLine("TERMINATED!");
            Console.ReadKey();

        }
    }
}
