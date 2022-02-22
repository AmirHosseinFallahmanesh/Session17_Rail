namespace Demo.Core.ApplicationService
{
    public interface IEmployeeRepositry
    {
        int CreateEmployee(Employee employee);
        Employee FindBySurname(string surname);
        int GetCount();
    }
}
