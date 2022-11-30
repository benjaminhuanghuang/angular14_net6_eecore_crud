

using FullStack.API.Data;
using FullStack.API.Models;
using FullStack.API.Services.Contract;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace FullStack.API.Services.Implementation
{

    public class DepartmentService : IDepartmentService
    {

        private readonly FullStackDbContext _dbContext;
        
        public DepartmentService(FullStackDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

       public async Task<List<Department>> GetList()
        {
            try
            {
                var departmentList = await this._dbContext.Departments.ToListAsync();
                return departmentList;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
