namespace LinqExercises
{
    public static class Exercise15
    {
        /*
            Given a list of employees, each with a Name, Department, and Salary, find the employee(s) with the highest salary in each department.
        */
        public static void Solve()
        {
            var employees = new List<Employee>
                        {
                            new Employee { Name = "Alice", Department = "HR", Salary = 60000 },
                            new Employee { Name = "Bob", Department = "IT", Salary = 90000 },
                            new Employee { Name = "Charlie", Department = "IT", Salary = 100000 },
                            new Employee { Name = "David", Department = "HR", Salary = 65000 },
                            new Employee { Name = "Eve", Department = "Marketing", Salary = 55000 }
                        };

            var employeesWithHighestSalary = employees.OrderByDescending(e => e.Salary).GroupBy(e => e.Department).Select((g) => g.First());

            foreach (var employee in employeesWithHighestSalary)
            {
                Console.WriteLine($"{employee.Name} from {employee.Department} earns the highest salary of {employee.Salary}");
            }
        }

        class Employee
        {
            public string Name { get; set; } = "";
            public string Department { get; set; } = "";
            public decimal Salary { get; set; }
        }
    }
}

