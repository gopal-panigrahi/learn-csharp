namespace LinqExercises
{
    public static class Exercise16
    {
        /*
            Given a list of employees with ID, Name, and SupervisorID, use a self-join to find all pairs of employees who report to the same supervisor.
        */
        public static void Solve()
        {
            var employees = new List<Employee>
                                {
                                    new Employee { Id = 1, Name = "Alice", SupervisorId = 3 },
                                    new Employee { Id = 2, Name = "Bob", SupervisorId = 3 },
                                    new Employee { Id = 3, Name = "Charlie", SupervisorId = null },
                                    new Employee { Id = 4, Name = "David", SupervisorId = 3 },
                                    new Employee { Id = 5, Name = "Eve", SupervisorId = 4 }
                                };

            var employeeWithSameSupervisor = employees.Join(employees, (e1) => e1.SupervisorId, (e2) => e2.SupervisorId, (e1, e2) => new { Employee1 = e1, Employee2 = e2 }).Where((p) => p.Employee1.Id < p.Employee2.Id);
            foreach (var emp in employeeWithSameSupervisor)
            {
                Console.WriteLine($"{emp.Employee1.Name} - {emp.Employee2.Name}");
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? SupervisorId { get; set; }
    }
}

