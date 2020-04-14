using Application.Data.Model;
using Application.Data.Repository;
using HotChocolate.Types;
using System.Threading.Tasks;

namespace HotChocolate.App.Type
{
    public class AppMutationType : ObjectType<Mutation> 
    {

    } 

    public partial class Mutation
    {
        private readonly IEmployeeRepository _employeeRepository;

        public Mutation(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public async Task<Employee> Create(Employee employee)
        {
            return await _employeeRepository.Create(employee);

        }
    } 
}
