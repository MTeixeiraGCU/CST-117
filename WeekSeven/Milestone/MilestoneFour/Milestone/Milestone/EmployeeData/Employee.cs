using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone.EmployeeData
{
    /**
     * <summary>Stores information to represent a single employee</summary>
     */
    public class Employee
    {
        //autoincrement value for employee id
        private static int _currentEmployeeId = 1;

        //private member variables
        private readonly int _employeeId;
        private string _employeeName;
        private decimal _employeeWage;
        private string _employeePosition;
        private string _employeeDepartment;

        //property fields
        public int EmployeeId
        {
            get { return _employeeId; }
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public decimal EmployeeWage
        {
            get { return _employeeWage; }
            set { _employeeWage = value; }
        }

        public string EmployeePosition
        {
            get { return _employeePosition; }
            set { _employeePosition = value; }
        }

        public string EmployeeDepartment
        {
            get { return _employeeDepartment; }
            set { _employeeDepartment = value; }
        }

        //default constructor
        public Employee()
        {
            _employeeId = _currentEmployeeId++;
            _employeeName = "";
            _employeeWage = 0.00m;
            _employeePosition = "";
            _employeeDepartment = "";
        }

        //assignment constructor
        public Employee(string name, decimal wage, string position, string department)
        {
            _employeeId = _currentEmployeeId++;
            _employeeName = name;
            _employeeWage = wage;
            _employeePosition = position;
            _employeeDepartment = department;
        }

        //copy constructor
        public Employee(Employee employee)
        {
            _employeeId = _currentEmployeeId;
            _employeeName = employee.EmployeeName;
            _employeeWage = employee.EmployeeWage;
            _employeePosition = employee.EmployeePosition;
            _employeeDepartment = employee.EmployeeDepartment;
        }

        //override for ToString to print a single employee to the console
        public override string ToString()
        {
            return string.Format("Id: {0} : Name: {1} : Wage: {2} : Position: {3} : Department: {4}/n",
                _employeeId,
                _employeeName,
                _employeeWage,
                _employeePosition,
                _employeeDepartment);
        }
    }
}
