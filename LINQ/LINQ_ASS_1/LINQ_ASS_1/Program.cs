using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ASS_1
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName, LastName, Title, City;
        public DateTime DOB, DOJ;

        static void Main()
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee{EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("16/11/1984"), DOJ = DateTime.Parse("08/06/2011"), City = "Mumbai" },
                new Employee{EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalia", Title = "AsstManager", DOB = DateTime.Parse("20/08/1984"), DOJ = DateTime.Parse("07/07/2012"), City = "Mumbai" },
                new Employee{EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("14/11/1987"), DOJ = DateTime.Parse("12/04/2015"), City = "Pune" },
                new Employee{EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("03/06/1990"), DOJ = DateTime.Parse("02/02/2016"), City = "Pune" },
                new Employee{EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("08/03/1991"), DOJ = DateTime.Parse("02/02/2016"), City = "Mumbai" },
                new Employee{EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("07/11/1989"), DOJ = DateTime.Parse("08/08/2014"), City = "Chennai" },
                new Employee{EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("02/12/1989"), DOJ = DateTime.Parse("01/06/2015"), City = "Mumbai" },
                new Employee{EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("06/11/2014"), City = "Chennai" },
                new Employee{EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("12/08/1992"), DOJ = DateTime.Parse("03/12/2014"), City = "Chennai" },
                new Employee{EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("12/04/1991"), DOJ = DateTime.Parse("02/01/2016"), City = "Pune" }
            };

            //a. Display detail of all the employee
            var empdetail = from emp in empList select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in empdetail)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //b. Display details of all the employee whose location is not Mumbai
            var notmumbai = from emp in empList where emp.City != "Mumbai" select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in notmumbai)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //c. Display details of all the employee whose title is AsstManager
            var asstmngr = from emp in empList where emp.Title == "AsstManager" select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in asstmngr)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //d. Display details of all the employee whose Last Name start with S
            var lstnmeS = from emp in empList where emp.LastName.StartsWith("S") select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in lstnmeS)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //e. Display a list of all the employee who have joined before 1/1/2015
            var joinedbefore = from emp in empList where emp.DOJ < DateTime.Parse("01/01/2015") select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in joinedbefore)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //f. Display a list of all the employee whose date of birth is after 1/1/1990
            var dobafter = from emp in empList where emp.DOB > DateTime.Parse("01/01/1990") select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in dobafter)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //g. Display a list of all the employee whose designation is Consultant and Associate
            var designation = from emp in empList where emp.Title == "Consultant" || emp.Title == "Associate" select emp;
            Console.WriteLine("------------------------------------------");
            foreach (Employee e in designation)
            {
                Console.WriteLine("Employee ID: {0} | First Name: {1} | Last Name: {2} | Title: {3} | Date of Birth: {4} | Date of Joining: {5} | City: {6}", e.EmployeeID, e.FirstName, e.LastName, e.Title, e.DOB.ToString("dd-MM-yyyy"), e.DOJ.ToString("dd-MM-yyyy"), e.City);
            }

            //h. Display total number of employees
            var totalemp = from emp in empList select emp;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Employees: {totalemp.Count()}");

            //i. Display total number of employees belonging to “Chennai”
            var empchennai = from emp in empList where emp.City == "Chennai" select emp;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Number of Employees from Chennai: " + empchennai.Count());

            //j. Display highest employee id from the list
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(empList.Max(m => m.EmployeeID));

            //k. Display total number of employee who have joined after 1/1/2015
            var empafter = from emp in empList where emp.DOJ > DateTime.Parse("01/01/2015") select emp;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Number of employees joined after 01/01/2015: {0}", empafter.Count());

            //l. Display total number of employee whose designation is not “Associate”
            var notassociate = from emp in empList where emp.Title != "Associate" select emp;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Count of Employees other than Associate: {notassociate.Count()}");

            //m. Display total number of employee based on City
            var city = from emp in empList.GroupBy(c => c.City) select new { cname = emp.First().City, cemp = emp.Count() };
            Console.WriteLine("------------------------------------------");
            foreach (var c in city)
            {
                Console.WriteLine($"City: {c.cname}\tEmployee Count: {c.cemp}");
            }

            //n. Display total number of employee based on city and title
            var cityntitle = from emp in empList.GroupBy(c => c.Title) select new { cname = emp.First().City, ctitle = emp.First().Title, cemp = emp.Count() };
            Console.WriteLine("------------------------------------------");
            foreach (var v in cityntitle)
            {
                Console.WriteLine($"City: {v.cname}\tTitle: {v.ctitle}\tEmployee Count: {v.cemp}");
            }

            //o. Display total number of employee who is youngest in the list
            Console.WriteLine("------------------------------------------");
            var youngest = empList.OrderBy(y => y.DOB).Last();
            Console.WriteLine($"Youngest Employee: {youngest.FirstName} {youngest.LastName}");
            Console.Read();
        }
    }