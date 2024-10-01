namespace LinqExercises
{
    public static class Exercise13
    {
        /*
            From a list of integers, find the second highest number.
        */
        public static void Solve()
        {
            List<int> numbers = new List<int> { 5, 3, 9, 1, 4, 8 };
            var secondHighest = numbers.OrderByDescending(n => n).Skip(1).First();
            Console.WriteLine(string.Join('\n', secondHighest));
        }
    }
}

