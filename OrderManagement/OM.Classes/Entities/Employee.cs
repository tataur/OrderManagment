using System;
using OM.Classes.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OM.Classes
{
    [Table("Emloyee")]
    public class Employee : CommonEntity 
    {
        public Guid FirstName { get; set; }
        public Guid SecondName { get; set; }
        public Guid Login { get; set; }
        public string Password { get; set; }
        public Position PositionInCompany { get; set; }
        public virtual Project Project { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    public enum Position
    {
        main, manager, builder
    }
}
