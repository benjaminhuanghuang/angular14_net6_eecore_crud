

using FullStack.API.Models;

namespace FullStack.API.Services.Contract
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetList();
    }
}
