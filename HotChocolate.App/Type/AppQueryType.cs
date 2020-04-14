using Application.Data.Model;
using Application.Data.Repository;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolate.App.Type
{
    class AppQueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetEmployees()) 
                .Description("Return all the list of an employee");
        }
    }

    public class QueryBase
    {

    }

    public partial class Query : QueryBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public Query(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        //Here order is important! 
        //Pageing -> Filtering -> Sorting -> Field Resolver

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetList();

        } 
    }

    public partial class Query : QueryBase 
    {
        public string Hello() => "World from Pradeep";
    }

}
