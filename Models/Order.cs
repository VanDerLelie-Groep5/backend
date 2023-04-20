using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Groep5_Van_Der_Lelie_Api.Enums;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public class Order : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        #nullable enable
        [Column("orderNumber")]
        public string? OrderNumber { get; set; }

        [Column("customerGroup")]
        public string? CustomerGroup { get; set; }

        [Column("entryDate")]
        public DateTime? entryDate { get; set; }

        [Column("reference")]
        public string? Reference { get; set; }

        [Column("space")]
        public string? Space { get; set; }

        [Column("status")]
        public string? Status { get; set; }

        [Column("product")]
        public string? Product { get; set; }

        [Column("fabricName")]
        public string? FabricName { get; set; }

        [Column("ready")]
        public DateTime? Ready { get; set; }

        // order can have one shift
        public Shift? Shift { get; set; }

        [Column("shiftId")]
        public int? ShiftId { get; set; }


        [Column("priority")]
        public string? Priority { get; set; }

        [Column("units")]
        public float? Units { get; set; }

    }
}
