

using FullStack.API.Data;
using FullStack.API.Models;
using FullStack.API.Services.Contract;
using Microsoft.EntityFrameworkCore;


namespace FullStack.API.Services.Implementation
{
    public class EmployeeService: IEmployeeService
    {
        private readonly FullStackDbContext _dbContext;

        public EmployeeService(FullStackDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<List<Employee>> GetList()
        {
            try
            {
                var employeeList = await this._dbContext.Employees.ToListAsync();
                return employeeList;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> Get(int id)
        {
            try
            {
                var employee = await this._dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

                return employee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         public async Task<Employee> Add(Employee model)
        {
            try
            {
                await this._dbContext.Employees.AddAsync(model);
                await _dbContext.SaveChangesAsync();

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> Update(Employee model)
        {
            try
            {
                this._dbContext.Employees.Update(model);
                await _dbContext.SaveChangesAsync();

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(Employee model)
        {
            try
            {
                this._dbContext.Employees.Remove(model);
                await this._dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
