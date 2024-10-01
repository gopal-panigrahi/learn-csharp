namespace LinqExercises
{
    public static class Exercise10
    {
        /*
            From a list of words, find those that appear more than once.
        */
        public static void Solve()
        {
            List<string> words = new List<string> { "apple", "banana", "apple", "cherry", "banana", "apple" };
            var repeatingWord = words.GroupBy(w => w).Where(g => g.Count() > 1).Select(g => g.Key);
            Console.WriteLine(string.Join('\n', repeatingWord));
        }
    }
}

