using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone.EmployeeData
{
    public class EmployeeManager
    {
        //Singleton instance of the EmployeeManager class
        private static EmployeeManager _instance;
        public static EmployeeManager Instance 
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new EmployeeManager();
                }
                return _instance;
            }
        }

        //List for storing the collection of Employees.
        private List<Employee> _employees;
        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }

        private EmployeeManager()
        {
            _employees = new List<Employee>();

            //Mock data loaded into the Employee data store.
            AddEmployee("Marc", 10.00m, "Laborer", "Construction");
            AddEmployee("Drake", 12.12m, "Operator", "Construction");
            AddEmployee("Chelly", 12.13m, "Clerk", "Front Office");
            AddEmployee("Steve", 42.00m, "Clerk", "Main Office");
            AddEmployee("Chelle", 19.00m, "Clerk", "Corporate Office");
            AddEmployee("Janice", 14.76m, "Doctor", "Medical");
            AddEmployee("Nat", 15.51m, "Nurse", "Medical");
            AddEmployee("David", 10.00m, "Assistant", "Medical");
            AddEmployee("Gray", 19.45m, "Assistant", "Store");
            AddEmployee("Kenith", 18.65m, "Stockroom", "Store");
        }

        //Gets a single employee by id, can return null
        public Employee Get(int id)
        {
            foreach(Employee employee in _employees)
            {
                if(employee.EmployeeId == id)
                {
                    return employee;
                }
            }
            return null;
        }

        //updates an existing employee with new data
        public bool UpdateEmployee(int id, string name, decimal wage, string position, string department)
        {
            //get the request employee
            Employee employee = this.Get(id);
            if(employee == null)
            {
                return false;
            }

            //update the fields for this employee
            employee.EmployeeName = name;
            employee.EmployeeWage = wage;
            employee.EmployeePosition = position;
            employee.EmployeeDepartment = department;

            return true;
        }

        //Adds an employee to the List.
        public void AddEmployee(string name, decimal wage, string position, string department)
        {
            //create new employee
            Employee employee = new Employee(name, wage, position, department);

            //add them to the List
            _employees.Add(employee);
        }

        //Removes an employee with the given id number.
        public void RemoveEmployee(int employeeId)
        {
            //get the request employee
            Employee employee = this.Get(employeeId);
            if (employee == null)
            {
                return;
            }

            _employees.Remove(employee);
        }

        //Searches through the collection of Employees by thier Name for the given pattern
        public List<Employee> SearchName(string pattern)
        {
            //ignore case
            pattern = pattern.ToLower();

            return Search("Name", pattern);
        }

        //Searches through the collection of Employees by thier Position for the given pattern
        public List<Employee> SearchPosition(string pattern)
        {
            //ignore case
            pattern = pattern.ToLower();

            return Search("Position", pattern);
        }

        //Searches through the collection of Employees by thier Department for the given pattern
        public List<Employee> SearchDepartment(string pattern)
        {
            //ignore case
            pattern = pattern.ToLower();

            return Search("Department", pattern);
        }

        //searches through the list of employees for the given pattern by the type. type can be either Name, Position, or Department
        private List<Employee> Search(string type, string pattern)
        {
            var searchList = new List<Employee>();

            //loop through all the employees
            for(int index = 0;index < _employees.Count;index++)
            {
                //determine the type and compare with pattern
                switch(type)
                {
                    case "Name":
                    {
                        if (_employees[index].EmployeeName.ToLower().Contains(pattern))
                        {
                            searchList.Add(_employees[index]);
                        }
                        break;
                    }
                    case "Position":
                    {
                        if (_employees[index].EmployeePosition.ToLower().Contains(pattern))
                        {
                            searchList.Add(_employees[index]);
                        }
                        break;
                    }
                    case "Department":
                    {
                        if (_employees[index].EmployeeDepartment.ToLower().Contains(pattern))
                        {
                            searchList.Add(_employees[index]);
                        }
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }

            return searchList;
        }

        //override for ToString to allow printing of the list to the console
        public override string ToString()
        {
            string strList = "";
            foreach(Employee employee in _employees)
            {
                strList += employee.ToString();
            }
            return strList;
        }
    }
}
