namespace LinqExercises
{
    public static class Exercise8
    {
        /*
            Join two collections of people by a common property (ID).
        */
        public static void Solve()
        {
            var people = new List<Person>
            {
                new Person { Id = 1, Name = "Alice" },
                new Person { Id = 2, Name = "Bob" }
            };
            var orders = new List<Order>
            {
                new Order { PersonId = 1, OrderName = "Laptop" },
                new Order { PersonId = 2, OrderName = "Phone" }
            };

            var tryJoin = people.Join(orders, (p) => p.Id, (o) => o.PersonId, (p, o) => new
            {
                p.Id,
                p.Name,
                o.OrderName
            });

            Console.WriteLine(string.Join('\n', tryJoin));
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        public class Order
        {
            public int PersonId { get; set; }
            public string OrderName { get; set; } = "";
        }
    }
}

