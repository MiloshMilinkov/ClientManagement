using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository){
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Employee>> GetEmployees(){
            var employees = await _employeeRepository.GetEmployees();
            return Ok(employees);
        }

        [HttpGet("{EmployeeId}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int EmployeeId){
            var employee = await _employeeRepository.GetEmployeeById(EmployeeId);
            if(employee == null){
                return NotFound();
            }
            return Ok(employee);
        }
    }
}