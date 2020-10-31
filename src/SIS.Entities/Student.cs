using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Entities
{
    [Table("Students", Schema = "SIS")]
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public long ClassId { get; set; }
    }
}
