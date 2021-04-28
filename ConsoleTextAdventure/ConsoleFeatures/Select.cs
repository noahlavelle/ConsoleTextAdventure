using System;
using System.Collections.Generic;

namespace ConsoleTextAdventure.ConsoleFeatures
{
    public class Select
    {
        private static Select _instance;

        private readonly Dictionary<ConsoleKey, Func<int, int>> _actions = new()
        {
            {ConsoleKey.UpArrow, selectedItem => selectedItem - 1},
            {ConsoleKey.DownArrow, selectedItem => selectedItem + 1},
            {
                ConsoleKey.Enter, selectedItem =>
                {
                    _instance.ItemSelected();
                    return selectedItem;
                }
            }
        };

        private readonly int _selectedItem;
        private readonly dynamic _items;
        private bool _itemSelected;

        public Select(string message, dynamic[] items)
        {
            _instance = this;
            var optionsCount = items.Length;
            _items = items;

            message += ":\n";
            Console.CursorVisible = false;
            DrawMulticoloredLine.Draw(new[]
            {
                new DrawMulticoloredLine.ColoredStringSection("? ", ColorScheme.PromptColor),
                new DrawMulticoloredLine.ColoredStringSection(message, ColorScheme.DefaultColor)
            });

            while (!_itemSelected)
            {
                for (var i = 0; i < optionsCount; i++)
                {
                    if (_selectedItem == i)
                    {
                        Console.ForegroundColor = ColorScheme.SelectionColor;
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    Console.WriteLine(items[i].InteractText);
                    Console.ResetColor();
                }

                var keyPressed = Console.ReadKey(true).Key;
                if (_actions.ContainsKey(keyPressed))
                    _selectedItem = Math.Clamp(_actions[keyPressed](_selectedItem), 0, optionsCount - 1);

                if (!_itemSelected) Console.CursorTop -= optionsCount;
            }
        }

        private void ItemSelected()
        {
            _itemSelected = true;
            Console.CursorVisible = true;

            if (_items[_selectedItem].CheckCanInteract())
                _items[_selectedItem].Interacted();
            else
                Console.WriteLine("Cannot Interact");
        }
    }
}