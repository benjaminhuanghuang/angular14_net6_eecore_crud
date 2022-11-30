﻿

using FullStack.API.Models;

namespace FullStack.API.Services.Contract
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetList();

        Task<Employee> Get(int id);

        Task<Employee> Add(Employee model);

        Task<Employee> Update(Employee model);

        Task<bool> Delete(Employee model);
    }
}
