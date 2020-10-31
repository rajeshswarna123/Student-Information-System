using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Entities
{
    [Table("ClassCurriculum", Schema = "SIS")]
    public class ClassCurriculum : BaseEntity
    {
        public long ClassId { get; set; }
        public long SubjectId { get; set; }
    }
}
