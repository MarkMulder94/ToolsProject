using CleanArchitecture.Application.Employees.Commands.CreateEmployee;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<long>> CreateEmployee(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);
        }


    }
}
