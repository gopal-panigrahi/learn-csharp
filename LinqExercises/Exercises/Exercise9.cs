namespace LinqExercises
{
    public static class Exercise9
    {
        /*
            From a list of integers, select the last 3 elements.
        */
        public static void Solve()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var last3Elements = numbers.Skip(Math.Max(0, numbers.Count() - 3));
            Console.WriteLine(string.Join('\n', last3Elements));
        }
    }
}

