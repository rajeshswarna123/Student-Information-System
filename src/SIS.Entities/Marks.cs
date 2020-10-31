using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Entities
{
    [Table("Marks", Schema = "SIS")]
    public class Marks : BaseEntity
    {
        public long SubjectId { get; set; }
        public long StudentId { get; set; }
        public int MaxMarks { get; set; }
        public int ObtainedMarks { get; set; }

    }
}
