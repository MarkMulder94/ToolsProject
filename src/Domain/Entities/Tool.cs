using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Tool
    {
        public int ToolId { get; set; }

        public string ToolName { get; set; }
        public string Description { get; set; }
    }
}
