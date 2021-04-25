using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTextAdventure.Objects;

namespace ConsoleTextAdventure
{
    public class Scene
    {
        private readonly dynamic[] _objects = {new Door(Door.Direction.North), new Door(Door.Direction.North)};

        public Scene()
        {
            // List<string> names = new List<string>();
            // foreach (dynamic sceneObject in _objects)
            // {
            //     names.Add(sceneObject.InteractText);
            // }
            //
            // Console.WriteLine(names.IndexOf(cities));
        }
    }
}