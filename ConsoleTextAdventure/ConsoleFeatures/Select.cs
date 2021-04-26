using System;
using System.Collections.Generic;

namespace ConsoleTextAdventure.ConsoleFeatures
{
    public class Select
    {
        public Select(string message, dynamic[] items)
        {
            int optionsCount = items.Length;
            int selectedItem = 0;
            bool itemSelected = false;

            while (!itemSelected) {
                for (int i = 0; i < optionsCount; i++) {
                    if (selectedItem == i) {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("> ");
                    } else {
                        Console.Write("  ");
                    }

                    Console.WriteLine(items[i].InteractText);
                    Console.ResetColor();
                    
                }

                switch (Console.ReadKey(true).Key) {
                    case ConsoleKey.UpArrow:
                        selectedItem = Math.Max(0, selectedItem - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem = Math.Min(optionsCount - 1, selectedItem + 1);
                        break;
                }

                selectedItem %= optionsCount;

                if (!itemSelected) {
                    Console.CursorTop -= optionsCount;
                }
            }
        }
    }
}