using System;
using ConsoleTextAdventure.ConsoleFeatures;
using ConsoleTextAdventure.Objects;
using ConsoleTextAdventure.Scenes;

namespace ConsoleTextAdventure
{
    internal static class Program
    {
        public static dynamic CurrentScene;

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ColorScheme.DefaultColor;
            StartSequence();
        }

        private static void StartSequence()
        {
            Player.Name = Prompt.Input("What is your name?");
            StartGame();
        }

        private static void StartGame()
        {
            Console.Clear();
            CurrentScene = new OpeningScene();
        }
    }
}