namespace LinqExercises
{
    public static class Exercise7
    {
        /*
            Given a list of words, find the top 3 longest words.
        */
        public static void Solve()
        {
            List<string> words = new List<string> { "apple", "banana", "watermelon", "grape", "kiwi", "blueberry" };
            var top3LongestWords = words.OrderByDescending(w => w.Length).Take(3);
            Console.WriteLine(string.Join('\n', top3LongestWords));
        }
    }
}

