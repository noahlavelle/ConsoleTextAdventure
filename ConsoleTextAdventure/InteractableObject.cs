using System;

namespace ConsoleTextAdventure
{
    public class InteractableObject
    {
        public string InteractText;

        public virtual void Interacted()
        {
            Console.WriteLine("");
        }
    }
}