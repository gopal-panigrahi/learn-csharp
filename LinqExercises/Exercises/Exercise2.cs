namespace LinqExercises
{
    public static class Exercise2
    {
        /*
            Given a list of names, select only those that start with the letter 'A'.
        */
        public static void Solve()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Anna", "George" };
            var namesWithA = names.Where((n) => n.StartsWith('A'));
            Console.WriteLine(string.Join('\n', namesWithA));
        }
    }
}

