using Company_Task.Controllers;
using Company_Task.Data;
using Company_Task.Models;
using Company_Task.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Company_Task.Repository
{
    public class EmployeeRepository : iEmployeeRepository
    {
        private readonly AppDbContext _dbContext;
        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(EmployeeViewModel employee)
        {
            var newEmployee = new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                MiddleName = employee.MiddleName,
                MobileNO = employee.PhoneNumber,
                State = employee.State,
                Country = employee.Country,
                District = employee.City,
                Addresss = employee.Address,
                //PostalCode = employee.PostalCode,
                //Location = employee.Location,
                CreatedDate = employee.CreatedDate,
            };
            await _dbContext.Employees.AddAsync(newEmployee);
            await _dbContext.SaveChangesAsync();
           
        }

        public async Task DeleteAsync(int id)
        {
            Employee employee = await _dbContext.Employees.FindAsync(id);
            _dbContext.Employees.Remove(employee);
            await _dbContext.SaveChangesAsync();
           
        }
        public async Task<List<EmployeeViewModel>> GetAllAsync()
        {
           List<Employee> employees = await _dbContext.Employees.ToListAsync();
           List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            foreach (var employee in employees) 
            {
                var employeeViewModel = new EmployeeViewModel
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    MiddleName = employee.MiddleName,
                    PhoneNumber = employee.MobileNO,
                    State = employee.State,
                    Country = employee.Country,
                    City = employee.District,
                    Address = employee.Addresss,
                    //PostalCode = employee.PostalCode,
                    //Location = employee.Location,
                    CreatedDate = employee.CreatedDate,
                };

                employeeViewModels.Add(employeeViewModel);
            }
            return employeeViewModels;
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
