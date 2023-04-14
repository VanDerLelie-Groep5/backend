using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public class Customer : BaseEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("customerNumber"), Required]
        public string CustomerNumber { get; set; }

        [Column("firstName"), Required]
        public string FirstName { get; set; }

        [Column("lastName")]
        #nullable enable
        public string? LastName { get; set; }

        [Column("gender")]
        public char? Gender { get; set; }

        [Column("emailAddress")]
        public string? EmailAddress { get; set; }

        [Column("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [Column("company")]
        public string? Company { get; set; }

        [Column("cocNumber")]
        public string? CocNumber { get; set; }

        #nullable enable
        public ICollection<Order>? Orders { get; set; }
    }
}
