using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    [Index(nameof(DepartmentNumber), IsUnique = true)]
    public class Department : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("departmentNumber"), Required]
        public int DepartmentNumber { get; set; }

        [Column("name"), Required]
        public string Name { get; set; }

        [Column("maxEmployees")]
        public int? MaxEmployees { get; set; }

        public ICollection<Shift> Shifts { get; set; }

    }
}
