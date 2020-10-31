using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SIS.Entities
{
    [Table("Classes", Schema = "SIS")]
    public class Class : BaseEntity
    {
        public string Name { get; set; }
    }
}
