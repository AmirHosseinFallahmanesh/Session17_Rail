using Demo.Core.ApplicationService;
using Moq;
using System;
using Xunit;

namespace Demo.Core.ApplicationServiceTest
{
    public class EmployeeFacadeTest
    {
        [Fact]
        public void CanAddEmployee()
        {
            Employee employee = new Employee() { Name = "amir", Surname = "amiri" };
            var repositoryMock = new Mock<IEmployeeRepositry>();
            repositoryMock.Setup(p => p.CreateEmployee(employee)).Returns(1);
            


            EmployeeFacade employeeFacade = new EmployeeFacade(repositoryMock.Object);
            EmployeeFacade employeeFacade1 = new EmployeeFacade(null);//dummy Object
            int result=employeeFacade.AddEmployee(employee);
            Assert.Equal(1, result);


        }

        [Fact]
        public void CanAddEmployeeFakeObject()
        {
            Employee employee = new Employee() { Name = "amir", Surname = "amiri" };
            

            EmployeeFacade employeeFacade = new EmployeeFacade(new EmployeeRepoitoryFake());
            int result = employeeFacade.AddEmployee(employee);
            Assert.Equal(1, result);


        }

        [Fact]
        public void CanGetActiveEmployeeWithSurname()
        {
            var repositoryMock = new Mock<IEmployeeRepositry>();
            repositoryMock.Setup(a => a.FindBySurname(It.IsAny<string>())).Returns(new Employee() { Active=true});

            EmployeeFacade employeeFacade = new EmployeeFacade(repositoryMock.Object);
            var employee=employeeFacade.SearchBySurname("test");
            Assert.True(employee.Active);


        }


        [Fact]
        public void ShoudThrowWhenGetDeactiveEmployeeWithSurname()
        {
            var repositoryMock = new Mock<IEmployeeRepositry>();
            repositoryMock.Setup(a => a.FindBySurname(It.IsAny<string>())).Returns(new Employee() { Active = false });

            EmployeeFacade employeeFacade = new EmployeeFacade(repositoryMock.Object);
            Assert.Throws<NullReferenceException>(() => employeeFacade.SearchBySurname("test"));


        }



        [Fact]
        public void CanAddItems()
        {
            var repositoryMock = new Mock<IEmployeeRepositry>();
            repositoryMock.SetupSequence(a => a.GetCount()).Returns(1).Returns(2).Returns(3);
            EmployeeFacade employeeFacade = new EmployeeFacade(repositoryMock.Object);
            int return1=employeeFacade.GetEmployeeCount();
            int return2=employeeFacade.GetEmployeeCount();
            int return3=employeeFacade.GetEmployeeCount();
            Assert.Equal(1, return1);
            Assert.Equal(2, return2);
            Assert.Equal(3, return3);


        }










    }
}
