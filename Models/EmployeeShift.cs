using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(ShiftId))]
    public class EmployeeShift : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("employeeId")]
        public int EmployeeId { get; set; }

        [Column("shiftId")]
        public int ShiftId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }

        [Column("startDateTime"), Required]
        public DateTime startDateTime { get; set; }

        [Column("endDateTime"), Required]
        public DateTime endDateTime { get; set; }
    }
}
