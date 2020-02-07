using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<long>
    {
        public string FirstName { get; set; }

        public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateEmployeeCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                var entity = new Employee
                {
                    FirstName = request.FirstName
                };
                _context.Employees.Add(entity);
                await _context.SaveChangesAsync(cancellationToken);
                return entity.EmployeeId;
            }
        }
    }
}





