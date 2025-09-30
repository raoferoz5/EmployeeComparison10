using System;

namespace EmployeeComparison
{
    // Employee class represents an employee with Id, FirstName, and LastName
    public class Employee
    {
        // Employee Id (used for equality check)
        public int Id { get; set; }

        // First name of the employee
        public string FirstName { get; set; }

        // Last name of the employee
        public string LastName { get; set; }

        // Overloading the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, return true
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one is null, return false
            if ((object)emp1 == null || (object)emp2 == null)
            {
                return false;
            }

            // Compare employees by Id
            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator (must be done in pairs with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals() method for consistency with operator overloading
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return this.Id == employee.Id;
            }
            return false;
        }

        // Override GetHashCode() whenever Equals() is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
