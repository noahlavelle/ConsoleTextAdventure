using ConsoleTextAdventure.Objects;

namespace ConsoleTextAdventure.Scenes
{
    public class OpeningScene : Scene
    {
        public OpeningScene()
        {
            Objects = new dynamic[] { new Door(Door.Direction.North), new Door(Door.Direction.East), new Chest() };
            SceneLoaded();
        }
    }
}