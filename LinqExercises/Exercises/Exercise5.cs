namespace LinqExercises
{
    public static class Exercise5
    {
        /*
            Group a list of words by their first letter.
        */
        public static void Solve()
        {
            List<string> words = new List<string> { "apple", "banana", "avocado", "blueberry", "cherry" };
            var groupByFirstCharacter = words.GroupBy(w => w[0]);
            foreach (var group in groupByFirstCharacter)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($" {item}");
                }
            }
        }
    }
}

