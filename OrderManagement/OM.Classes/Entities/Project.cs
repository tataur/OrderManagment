using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using OM.Classes.Entities;

namespace OM.Classes
{
    [Table("Project")]
    public class Project : CommonEntity
    {
        public string Name { get; set; }
        public Guid EmployeeId { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
    }
}
