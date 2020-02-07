using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Tools.Commands
{
    public class CreateToolCommand : IRequest<string>
    {
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string Description { get; set; }

        public class Handler : IRequestHandler<CreateToolCommand, string>
        {
            private readonly IApplicationDbContext _context;

            public Handler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<string> Handle(CreateToolCommand request, CancellationToken cancellationToken)
            {
                var entity = new Tool
                {
                    ToolId = request.ToolId,
                    ToolName = request.ToolName,
                    Description = request.Description,
                };

                _context.Tools.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return $"{entity.ToolName} is toegevoed";          
            }
        }

    }
}
