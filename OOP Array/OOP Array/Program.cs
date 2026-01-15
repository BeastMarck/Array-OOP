using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Song[,] songs = new Song[2,3];
            
            //Example Songs
            songs[0,0] = new GameSong("IVORY Tower", "Hiroyuki SAWANO · SennaRin", "July 12, 2024", "Dragon Raja");
            songs[0,1] = new GameSong("Bury the Light", "Casey Edwards", "August 26, 2024", "Devil May Cry");
            songs[0,2] = new GameSong("Wildfire", "HOYO-Mix", "May 1, 2023", "Honkai: Star Rail");
            songs[1,0] = new BandSong("Bismarck", "Sabaton", " Dec 31, 2019", "English");
            songs[1,1] = new BandSong("Color", "FLOW", "Nov 5, 2013", "Japanese");


            //Outer for Loop
            for (int r = 0; r < songs.GetLength(0); r++)
            {
                //For Subclass labels
                if (r == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----GameSong----");
                    Console.ResetColor();
                }
                else if (r == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----BandSong----");
                    Console.ResetColor();
                }
                //Inner Loop
                for (int c = 0; c < songs.GetLength(1); c++)
                {
                    //Due to song[1,2] not existing in my Activity I made this if condition so the code can still display the intended output
                    if (songs[r, c] != null)
                    {
                        songs[r, c].Diplay();
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
