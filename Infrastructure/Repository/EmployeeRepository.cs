using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDBContext _appDBContext;
        public EmployeeRepository(AppDBContext appDBContext){
            _appDBContext = appDBContext;
        }
        public async Task<IReadOnlyList<Employee>> GetEmployees()
        {
            return await _appDBContext.Employees.ToListAsync();
        }
        public async Task<Employee> GetEmployeeById(int EmployeeId){
            return await _appDBContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == EmployeeId);
        }
    }
}