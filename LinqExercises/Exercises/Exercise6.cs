namespace LinqExercises
{
    public static class Exercise6
    {
        /*
            From a list of integers, compute the sum of all even numbers.
        */
        public static void Solve()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var evenSum = numbers.Where((n) => n % 2 == 0).Sum();
            Console.WriteLine(evenSum);
        }
    }
}

