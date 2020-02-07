using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Employee 
    {
        public Employee()
        {
            Inventory = new List<Tool>();
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public IList<Tool> Inventory { get; set; }
    }
}
