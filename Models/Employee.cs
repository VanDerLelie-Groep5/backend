using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    [Index(nameof(EmployeeNumber), IsUnique = true)]
    public class Employee : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("employeeNumber"), Required]
        public string EmployeeNumber { get; set; }

        [Column("firstName"), Required]
        public string FirstName { get; set; }

        [Column("lastName")]
        #nullable enable
        public string? LastName { get; set; }

        [Column("emailAddress")]
        public string? EmailAddress { get; set; }

        [Column("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [Column("gender")]
        public char? Gender { get; set; }

        [Column("unitsPerHour"), Required]
        public double UnitsPerHour { get; set; }

        [Column("preferenceDepartmentId")]
        public int? PreferenceDepartmentId { get; set; }

        public virtual ICollection<EmployeeShift>? EmployeeShifts { get; set; }

          
    }
}
