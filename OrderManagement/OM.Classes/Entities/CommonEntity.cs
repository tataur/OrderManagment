using System;
using System.ComponentModel.DataAnnotations;

namespace OM.Classes.Entities
{
    public abstract class CommonEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
