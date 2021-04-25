namespace ConsoleTextAdventure.ConsoleFeatures
{
    public static class Prompt
    {
        public static string Input(string message)
        {
            Input input = new Input(message);
            return input.Answer;
        }
    }
}