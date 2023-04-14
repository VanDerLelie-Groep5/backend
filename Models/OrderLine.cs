using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public class OrderLine : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        public Order Order { get; set; }

        [Column("orderId"), Required]
        public int OrderId { get; set; }

        public Department Department { get; set; }

        [Column("departmentId")]
        public int? DepartmentId { get; set; }

        public ICollection<Unit> Units { get; set; }
    }
}
