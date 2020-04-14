using Application.Data.DataContext;
using Application.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            this._db = db;
        }


        public async Task<IQueryable<Employee>> GetList()
        {
            var result = _db.Employee
                .Include(x => x.Addresses)
                .AsQueryable();
            return await Task.FromResult(result);
        }

        public async Task<Employee> GetById(int id)
        {
            return await Task.FromResult(_db.Employee.FirstOrDefault(x => x.Id == id));
        }
    }
}
