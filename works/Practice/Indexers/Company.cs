using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Company
    {
        private List<Employees> _employeeList;

        public Company()
        {
            _employeeList = new List<Employees>();

            _employeeList.Add(new Employees { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
            _employeeList.Add(new Employees { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
            _employeeList.Add(new Employees { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
            _employeeList.Add(new Employees { EmployeeId = 104, Name = "Priyanka", Gender = "Female", Salary = 4000 });
            _employeeList.Add(new Employees { EmployeeId = 105, Name = "Hina", Gender = "Female", Salary = 3000 });
            _employeeList.Add(new Employees { EmployeeId = 106, Name = "Sambit", Gender = "Male", Salary = 6000 });
            _employeeList.Add(new Employees { EmployeeId = 107, Name = "Tarun", Gender = "Male", Salary = 8000 });
            _employeeList.Add(new Employees { EmployeeId = 108, Name = "Santosh", Gender = "Male", Salary = 7000 });
            _employeeList.Add(new Employees { EmployeeId = 109, Name = "Trupti", Gender = "Female", Salary = 5000 });
        }


        // The indexer takes an employeeId as parameter
        // and returns the employee name
        public string this[int employeeId]
        {
            get
            {
                return _employeeList.FirstOrDefault(e => e.EmployeeId == employeeId).Name;
            }
            set
            {
                _employeeList.FirstOrDefault(e => e.EmployeeId == employeeId).Name = value;
            }
        }


        // The indexer takes a gender as parameter
        // and returns the total count of that gender
        public string this[string gender]
        {
            get
            {
                return _employeeList.Count(e => e.Gender.ToLower() == gender.ToLower()).ToString();
            }

            // Changes the gender of all employees whose gender matches
            // with the gender that is passed in.
            set
            {
                foreach(Employees employee in _employeeList)
                {
                    if(employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}
