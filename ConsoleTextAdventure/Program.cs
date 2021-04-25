using System;
using System.Threading;
using ConsoleTextAdventure.ConsoleFeatures;

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
            // Player.Name = Prompt.Input<string>("What is your name?", null,
            //     new[] {Validators.Required(), Validators.MinLength(3), Validators.MaxLength(16)});
            //
            // bool start = Prompt.Confirm($"Welcome {Player.Name}. Are you ready to start your adventure?");
            //
            // if (start)
            // {
            //     StartGame();
            // }
            // else
            // {
            //     Console.WriteLine("Goodbye then");
            //     Thread.Sleep(1000);
            // }

            Console.WriteLine(Prompt.Input("What is your name?"));
        }

        static void StartGame()
        {
            Console.Clear();
            new Scene();
        }
    }
}