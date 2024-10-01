namespace LinqExercises
{
    public static class Exercise3
    {
        /*
            Given a list of strings, return a new list where each string is in uppercase.
        */
        public static void Solve()
        {
            List<string> words = new List<string> { "apple", "banana", "cherry" };
            var upperCaseList = words.Select((w) => w.ToUpper());
            Console.WriteLine(string.Join('\n', upperCaseList));
        }
    }
}

