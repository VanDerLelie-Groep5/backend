using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public class Order : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        #nullable enable
        [Column("orderNumber")]
        public string? OrderNumber { get; set; }
        
        public Customer? Customer { get; set; }

        [Column("customerId")]
        public int? CustomerId { get; set; }

        public ICollection<OrderLine>? OrderLines { get; set; }

    }
}
