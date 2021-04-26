using System;
using System.Threading;
using ConsoleTextAdventure.ConsoleFeatures;
using ConsoleTextAdventure.Objects;

namespace ConsoleTextAdventure
{
    static class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }

        static void StartSequence()
        {
            Console.WriteLine(Prompt.Input("What is your name?"));
            Prompt.Select("Hello", new[] {new Door(Door.Direction.North), new Door(Door.Direction.North)});
        }

        static void StartGame()
        {
            Console.Clear();
            new Scene();
        }
    }
}