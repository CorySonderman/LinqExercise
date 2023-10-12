using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum:");
            Console.Write(numbers.Sum());
            Console.WriteLine();
            Console.WriteLine();
            

            //TODO: Print the Average of numbers
            Console.WriteLine("Average:");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the
            //console
            Console.WriteLine("Numbers Ascending:");
            numbers.OrderBy(numbers => numbers).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console 
            Console.WriteLine("Numbers Descending:");
            numbers.OrderByDescending(numbers => numbers).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Greater Than 6");
            numbers.Where(numbers => numbers >6).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only
            //print 4 of them **foreach loop only!**
            Console.WriteLine("And Then There Were 4!");
            foreach (var number in numbers.OrderBy(numbers => numbers).Take(4))
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the
            //numbers in descending order
            Console.WriteLine("Replacing index 4 with my age:");
            numbers.SetValue(48, 4);
            numbers.OrderByDescending(numbers => numbers).ToList().ForEach(numbers => Console.WriteLine(numbers));

            Console.WriteLine();
            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the
            //console only if their FirstName starts with a C OR an S and
            //order this in ascending order by FirstName.
            Console.WriteLine("Employees with first initial C or S:");
            employees.Where(emp => emp.FirstName.StartsWith('C') ||
            emp.FirstName.StartsWith('S')).OrderBy(emp => emp.FirstName).ToList()
            .ForEach(emp => Console.WriteLine(emp.FullName));
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age
            //26 to the console and order this by Age first and then by FirstName
            //in the same result.
            Console.WriteLine("Employees over 26:");
            employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).
                ThenBy(emp => emp.FirstName).ToList().
                ForEach(emp => Console.WriteLine($"Name: {emp.FullName} " +
                $"Age: {emp.Age}")); 

            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees'
            //YearsOfExperience if their YOE is less than or equal to 10 AND Age is
            //greater than 35.
            Console.WriteLine("Sum - Years of experience:");
            var employeeSum = employees.Where(emp => emp.YearsOfExperience <= 10 && 
            emp.Age > 35).Sum(emp  => emp.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine();
            Console.WriteLine("Average - Years of experience:");
            var employeeAvg = employees.Where(emp => emp.YearsOfExperience <= 10 &&
            emp.Age > 35).Average(emp => emp.YearsOfExperience);
            Console.WriteLine (Math.Round(employeeAvg, 2));
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using
            //employees.Add()
       
            Employee newEmployee = new Employee
            {
                FirstName = "Cory",
                LastName = "Sonderman",
                Age = 48,
                YearsOfExperience = 0,               
            };
            employees.Append(newEmployee).ToList().ForEach(emp => Console.WriteLine(emp.FullName));


            Console.ReadLine();
        }

        private static void var(int obj)
        {
            throw new NotImplementedException();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
