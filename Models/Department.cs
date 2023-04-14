using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    [Index(nameof(Number), IsUnique = true)]
    public class Department : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("number"), Required]
        public int Number { get; set; }

        [Column("maxEmployees")]
        public int? MaxEmployees { get; set; }

        public ICollection<Shift> Shifts { get; set; }

    }
}
