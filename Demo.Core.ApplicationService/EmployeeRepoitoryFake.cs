namespace Demo.Core.ApplicationService
{
    public class EmployeeRepoitoryFake : IEmployeeRepositry
    {
        public int CreateEmployee(Employee employee)
        {
            return 1;
        }

        public Employee FindBySurname(string surname)
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }
    }
}
