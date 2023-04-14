using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public class Shift : BaseEntity
    {

        [Key, Column("id")]
        public int Id { get; set; }

        [Column("startDateTime"), Required]
        public DateTime StartDateTime { get; set; }

        [Column("endDateTime"), Required]
        public DateTime EndDateTime { get; set; }
        
        public Department Department { get; set; }

        [Column("departmentId"), Required]
        public int DepartmentId { get; set; }

        #nullable enable
        public virtual ICollection<EmployeeShift>? EmployeesShifts { get; set;}

        


    }
}
