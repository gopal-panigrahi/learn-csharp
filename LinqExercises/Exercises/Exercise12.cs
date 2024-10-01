namespace LinqExercises
{
    public static class Exercise12
    {
        /*
            Flatten a list of lists into a single list of integers.
        */
        public static void Solve()
        {
            var listOfLists = new List<List<int>>
                                {
                                    new List<int> { 1, 2, 3 },
                                    new List<int> { 4, 5 },
                                    new List<int> { 6, 7, 8 }
                                };
            var flatList = listOfLists.SelectMany(l => l);
            Console.WriteLine(string.Join('\n', flatList));
        }
    }
}

