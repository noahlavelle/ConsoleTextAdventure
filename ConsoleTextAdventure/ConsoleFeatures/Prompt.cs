namespace ConsoleTextAdventure.ConsoleFeatures
{
    public static class Prompt
    {
        public static string Input(string message)
        {
            var input = new Input(message);
            return input.Answer;
        }

        public static void Select(string message, dynamic[] items)
        {
            var select = new Select(message, items);
        }
    }
}