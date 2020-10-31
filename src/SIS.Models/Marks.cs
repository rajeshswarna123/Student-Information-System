using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Models
{
    public class Marks
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public int MaxMarks { get; set; }

        public int ObtainedMarks { get; set; }
    }
}
