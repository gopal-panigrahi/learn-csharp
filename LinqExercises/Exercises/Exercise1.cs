namespace LinqExercises
{
    /*
        Given a list of integers, use LINQ to find all even numbers.
    */
    public static class Exercise1
    {
        public static void Solve()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where((n) => n % 2 == 0);
            Console.WriteLine(string.Join(',', evenNumbers));
        }
    }
}