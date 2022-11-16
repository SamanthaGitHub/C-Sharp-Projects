using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 2
            Employee One = new Employee() { ID = 1, FirstName = "Joe", LastName = "Shmoe" }; //employees
            Employee Two = new Employee() { ID = 2, FirstName = "Roe", LastName = "Shmoe" };
            Employee Three = new Employee() { ID = 3, FirstName = "Boe", LastName = "Shmoe" };
            Employee Four = new Employee() { ID = 4, FirstName = "Loe", LastName = "Shmoe" };
            Employee Five = new Employee() { ID = 5, FirstName = "Poe", LastName = "Shmoe" };
            Employee Six = new Employee() { ID = 6, FirstName = "Joe", LastName = "Shmoe" };
            Employee Seven = new Employee() { ID = 7, FirstName = "Zoe", LastName = "Shmoe" };
            Employee Eight = new Employee() { ID = 8, FirstName = "Steve", LastName = "Shmoe" };
            Employee Nine = new Employee() { ID = 9, FirstName = "Bob", LastName = "Shmoe" };
            Employee Ten = new Employee() { ID = 10, FirstName = "Bill", LastName = "Shmoe" };

            List<Employee> empList = new List<Employee>() { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }; //employee list

            List<Employee> firstList = new List<Employee>(); //initialize list to add 'Joe's to

            //Part 3
            foreach (Employee emp in empList)
            {
                if (emp.FirstName == "Joe")
                {
                    firstList.Add(emp);
                    Console.WriteLine(emp.FirstName); //prints Joe X2
                }
            }
            Console.ReadLine();

            //Part 4
            //lamda expression to add both Joes to new list
            List<Employee> secondList = empList.FindAll(x => x.FirstName == "Joe");
            foreach (Employee emp in secondList)
            {
                Console.WriteLine(emp.FirstName); //prints Joe X2
            }
            Console.ReadLine();

            //Part 5
            //lamda expression for list of employees with id > 5
            List<Employee> thirdList = empList.FindAll(x => x.ID > 5);
            foreach (Employee emp in thirdList)
            {
                Console.WriteLine(emp.ID); //prints 6, 7, 8, 9, 10
            }
            Console.ReadLine();
        }
    }
}
