using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public class Unit
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("value"), Required]
        public double Value { get; set; }

        public Shift Shift { get; set; }

        [Column("shiftId")]
        public int? ShiftId { get; set; }

        public OrderLine OrderLine { get; set; }

        [Column("orderLineId"), Required]
        public int OrderLineId { get; set; }

        [Column("priority")]
        public int? Priority { get; set; }
    }
}
