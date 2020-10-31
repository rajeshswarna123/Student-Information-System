using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Entities
{
    [Table("Subjects", Schema = "SIS")]
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
    }
}
