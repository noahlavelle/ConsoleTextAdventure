using System;

namespace ConsoleTextAdventure.ConsoleFeatures
{
    public class Input
    {
        public string Answer;

        public Input(string message)
        {
            message += ": ";

            DrawMulticoloredLine.Draw(new DrawMulticoloredLine.ColoredStringSection[]
                {new("? ", ColorScheme.PromptColor), new(message, ColorScheme.DefaultColor)});
            var answer = Console.ReadLine();
            Answer = answer;
        }
    }
}