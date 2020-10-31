using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Entities
{
    [Table("Users", Schema = "SIS")]
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
