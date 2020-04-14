using Application.Data.Model;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Data.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<IQueryable<Employee>> GetList();
    }
}