using Company_Task.Models;
using Company_Task.ViewModel;
namespace Company_Task.Repository
{
    public interface iEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int id);
        Task<List<EmployeeViewModel>> GetAllAsync();

        Task AddAsync(EmployeeViewModel employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);

    }
}
