using CleanArchitecture.Application.Employees.Commands.CreateEmployee;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Employees.Queries;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.WebUI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await Mediator.Send(new GetAllEmployeesQuery());
        }
        [HttpPost]
        public async Task<ActionResult<long>> CreateEmployee(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);
        }


    }
}
