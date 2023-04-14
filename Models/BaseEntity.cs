using System.ComponentModel.DataAnnotations.Schema;

namespace Groep5_Van_Der_Lelie_Api.Models
{
    public abstract class BaseEntity
    {
        [Column("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }
}
