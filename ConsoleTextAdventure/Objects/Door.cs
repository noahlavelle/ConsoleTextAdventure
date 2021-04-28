using System;

namespace ConsoleTextAdventure.Objects
{
    public class Door : InteractableObject
    {
        public enum Direction
        {
            North,
            East,
            South,
            West
        }

        public Door(Direction doorDirection)
        {
            InteractText = $"Enter the door facing {doorDirection}";
        }

        public override void Interacted()
        {
            base.Interacted();
            Console.WriteLine("Door Interacted");
        }
    }
}