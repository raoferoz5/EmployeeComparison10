using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object and assign values
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create second Employee object and assign values
            Employee emp2 = new Employee
            {
                Id = 1, // Same Id as emp1 → should be equal
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare emp1 and emp2 using overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 and emp2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are NOT equal (different Id).");
            }

            // Compare emp1 and emp2 using overloaded != operator
            if (emp1 != emp2)
            {
                Console.WriteLine("emp1 and emp2 are NOT equal (different Id).");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are equal (same Id).");
            }

            // Keep console open until user presses a key
            Console.ReadKey();
        }
    }
}
