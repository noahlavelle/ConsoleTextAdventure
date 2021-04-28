using System;

namespace ConsoleTextAdventure
{
    public class InteractableObject
    {
        protected bool CanInteract = true;
        public string InteractText;

        public virtual void Interacted()
        {
            Console.WriteLine("");
        }

        public virtual bool CheckCanInteract()
        {
            return CanInteract;
        }
    }
}