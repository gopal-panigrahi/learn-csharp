namespace LinqExercises
{
    public static class Exercise11
    {
        /*
            Given a list of employees with Name and Department, group employees by department, order each group by name, and project to a new list with department name and sorted employee names.
        */
        public static void Solve()
        {
            var employees = new List<Employee>
                                {
                                    new Employee { Name = "Alice", Department = "HR" },
                                    new Employee { Name = "Bob", Department = "IT" },
                                    new Employee { Name = "Carol", Department = "HR" },
                                    new Employee { Name = "David", Department = "IT" }
                                };

            var result = employees.GroupBy((e) => e.Department).Select((g) => new
            {
                Deparment = g.Key,
                Names = g.OrderBy(i => i.Name).Select(i => i.Name)
            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Deparment}: {string.Join(',', item.Names)}");
            }
        }

        public class Employee
        {
            public string Name { set; get; } = "";
            public string Department { set; get; } = "";
        }
    }
}

