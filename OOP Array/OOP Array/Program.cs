using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Song[] songs = new Song[5];

            songs[0] = new GameSong("IVORY Tower", "Hiroyuki SAWANO · SennaRin", "July 12, 2024", "Dragon Raja");
            songs[1] = new GameSong("Bury the Light", "Casey Edwards", "August 26, 2024", "Devil May Cry");
            songs[2] = new GameSong("Wildfire", "HOYO-Mix", "May 1, 2023", "Honkai: Star Rail");
            songs[3] = new BandSong("Bismarck", "Sabaton", " Dec 31, 2019", "English");
            songs[4] = new BandSong("Color", "FLOW", "Nov 5, 2013", "Japanese");

            foreach (Song song in songs)
            {
                song.Diplay();
            }

            Console.ReadKey();

        }
    }
}
