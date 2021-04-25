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
            West,
        }

        public readonly Direction DoorDirection;

        public Door(Direction doorDirection)
        {
            DoorDirection = doorDirection;
            InteractText = $"Enter the door facing {DoorDirection}";
        }

        public override void Interacted()
        {
            base.Interacted();
            Console.WriteLine("Door Interacted");
        }
    }
}