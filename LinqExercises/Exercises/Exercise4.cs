namespace LinqExercises
{
    public static class Exercise4
    {
        /*
            Given a list of words, order them by the length of the word.
        */
        public static void Solve()
        {
            List<string> words = new List<string> { "apple", "kiwi", "banana", "pear" };
            var orderedByLength = words.OrderBy(w => w.Length);
            Console.WriteLine(string.Join('\n', orderedByLength));
        }
    }
}

