using System.ComponentModel.DataAnnotations;

namespace SIS.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
