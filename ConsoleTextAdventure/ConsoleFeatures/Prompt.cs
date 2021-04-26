namespace ConsoleTextAdventure.ConsoleFeatures
{
    public static class Prompt
    {
        public static string Input(string message)
        {
            Input input = new Input(message);
            return input.Answer;
        }

        public static void Select(string message, dynamic[] items) {
            Select select = new Select(message, items);
        }
    }
}