using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Array
{
    class Song
    {

        //Tacal,John Jenson
        //REQUIREMENTS:
        //Re-use your code in Activity 2.
        //In your main program, use two-dimensional array of objects
        //You have to use loop structure to access the 2D array of objects

        //Variables
        public string Title { get; set; }
        public string Composer { get; set; }
        public string ReleaseDate { get; set; }
        //Constructor
        public Song(string title, string composer, string releasedate)
        {
            Title = title;
            Composer = composer;
            ReleaseDate = releasedate;
        }
        //Method
        public virtual void Diplay()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Composer: {Composer}");
            Console.WriteLine($"Release Date {ReleaseDate}");
            Console.WriteLine("");
        }
    }

    class GameSong : Song //child class
    {
        //Variable
        public string Game { get; set; }
        //Constructor
        public GameSong(string title, string composer, string releasedate, string game) : base(title, composer, releasedate)
        {
            Game = game;
        }
        //Method
        public override void Diplay()
        {
            Console.WriteLine($"Game: {Game}");
            base.Diplay();
        }
    }

    class BandSong : Song //child class
    {
        //Variable
        public string Language { get; set; }
        //Constructor
        public BandSong(string title, string composer, string releasedate, string language) : base(title, composer, releasedate)
        {
            Language = language;
        }
        //Method
        public override void Diplay()
        {
            Console.WriteLine($"Language: {Language}");
            base.Diplay();
        }
    }
}
