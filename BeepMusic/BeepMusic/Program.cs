using System;
using System.Collections.Generic;

namespace Player
{
    class BeepMusic
    {

        static void Main(string[] args)
        {
            Song song = new Song();
            Score score = new Score();
            string note;
            string duration;
            bool start = true;
            string prompt;
            Console.WriteLine("Enter Tempo in BPM");
            score.BPM = Convert.ToInt32(Console.ReadLine());

            while (start)
            {
                Console.WriteLine("Enter Note (A-G)");
                note = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter note size (SIXTEENTH - WHOLE)");
                duration = Console.ReadLine().ToUpper();
                score.AddNote(note, duration);
                Console.WriteLine("Would you like to add another note? (y / n)");
                prompt = Console.ReadLine().ToLower();
                if (prompt == "n" || prompt == "")
                {
                    start = false;
                }
            }

            song.Play(score);
        }
    }
    class Song
    {
        public void Play(Score tune)
        {
            foreach (Score.Note n in tune.notes)
            {
                Console.Beep((int)n.NoteTone, n.NoteDuration);
            }
        }
        public void Play()
        {
            Console.Beep();
        }
    }
    class Score
    {
        public int BPM;
        public List<Note> notes = new List<Note>();

        public void AddNote(string frequency, string time)
        {
            Tone tone = (Tone)Enum.Parse(typeof(Tone), frequency);
            int duration = GetDuration(time);
            notes.Add(new Note(tone, duration));
        }

        public enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
        }
        private int GetDuration (string time)
        {
            int qt = 60000 / BPM;
            switch (time)
            {
                case "WHOLE":
                    return (int)qt * 4;
                case "HALF":
                    return (int)qt*2;
                case "QUARTER":
                    return (int)qt;
                case "EIGHTH":
                    return (int)qt / 2;
                case "SIXTEENTH":
                    return (int)qt / 4;
                default:
                    return 1000;
            }
        }
        public struct Note
        {
            Tone toneVal;
            int durVal;
            public Note(Tone frequency, int time)
            {
                toneVal = frequency;
                durVal = time;
            }
            public Tone NoteTone { get { return toneVal; } }
            public int NoteDuration { get { return durVal; } }
    }
}
}