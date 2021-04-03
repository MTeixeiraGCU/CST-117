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

        //counter to track number of employees
        private int _numberOfEmployees;

        //Array for storing the collection of Employees.
        private Employee[] _employees;

        private EmployeeManager()
        {
            _employees = new Employee[10];
            _numberOfEmployees = 0;

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

        //Adds an employee to the array
        public void AddEmployee(string name, decimal wage, string position, string department)
        {
            //create new employee
            Employee employee = new Employee(name, wage, position, department);
            
            //dynamically increase array size and copy over employees if the array is full
            if(_numberOfEmployees == _employees.Length)
            {
                Employee[] tempArray = _employees;
                //double the array size when it becomes full to decrase the number of full copy-overs
                _employees = new Employee[_employees.Length * 2];
                for (int index = 0; index < tempArray.Length; index++)
                {
                    _employees[index] = tempArray[index];
                }
            }
            
            //add the new employee
            _employees[_numberOfEmployees] = employee;
            _numberOfEmployees++;
        }

        //Removes an employee with the given id number
        public void RemoveEmployee(int employeeId)
        {
            Employee[] tempArray = _employees;
            _employees = new Employee[_employees.Length];

            //create a new array and remove the employee with the matching ID
            int offset = 0; //variable to help determine when we are past the removed employee
            for(int index = 0;index < _numberOfEmployees;index++)
            {
                if(tempArray[index].EmployeeId != employeeId)
                {
                    _employees[index + offset] = tempArray[index];
                }
                else
                {
                    offset = -1;
                }
            }

            //decrement employee counter
            _numberOfEmployees--;
        }

        //searches through the array of employees for the given pattern by the type. type can be either Name, Position, or Department
        public List<Employee> Search(string type, string pattern)
        {
            var searchList = new List<Employee>();

            //ignore case
            pattern = pattern.ToLower();

            //loop through all the employees
            for(int index = 0;index < _numberOfEmployees;index++)
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

        //Gets a List of all the existing employees for graphical representation
        public List<Employee> ToList()
        {
            return _employees.Take(_numberOfEmployees).ToList();
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
