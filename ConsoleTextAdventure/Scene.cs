using System;
using ConsoleTextAdventure.ConsoleFeatures;
using ConsoleTextAdventure.Objects;

namespace ConsoleTextAdventure
{
    public class Scene
    {
        public dynamic[] Objects;

        protected void SceneLoaded()
        {
            Prompt.Select("You have entered a new room. What do you want to do?", Objects);
        }
    }
}