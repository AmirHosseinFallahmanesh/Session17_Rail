using System;

namespace Demo.Core.ApplicationService
{
    public class EmployeeFacade
    {
        private readonly IEmployeeRepositry employeeRepositry;

        public EmployeeFacade(IEmployeeRepositry employeeRepositry)
        {
            this.employeeRepositry = employeeRepositry;
        }
        public int AddEmployee(Employee employee)
        {
            return this.employeeRepositry.CreateEmployee(employee);
        }


        public Employee SearchBySurname(string surname)
        {
           var employee= employeeRepositry.FindBySurname(surname);
            if (!employee.Active)
            {
                throw new NullReferenceException();
            }
            return employee;
        }


        public int GetEmployeeCount()
        {
            return employeeRepositry.GetCount();
        }
    }


   
}
