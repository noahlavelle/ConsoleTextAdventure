using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleTextAdventure.ConsoleFeatures
{
    public class Input
    {
        public string Answer;
        
        public Input(string message)
        {
            message += ": ";
            
            DrawMulticoloredLine.Draw(new DrawMulticoloredLine.ColoredStringSection[] {new("? ", ConsoleColor.DarkGreen), new(message, ConsoleColor.White)});
            string answer = Console.ReadLine();
            Answer = answer;
        }
    }
}