namespace LinqExercises
{
    public static class Exercise14
    {
        /*
            Given a list of numbers, return a comma-separated string of the numbers in ascending order.
        */
        public static void Solve()
        {
            List<int> numbers = new List<int> { 5, 2, 8, 3, 1 };

            var stringOfNums = string.Join(',', numbers.OrderBy(n => n));
            Console.WriteLine(stringOfNums);
        }
    }
}

