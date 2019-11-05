using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Models
{
    public class TeacherStudent
    {
        //this a table of the releations between a lot of and a lot of
        public int StudentId { get; set; }
        public int TeacherOfStudentId { get; set; }
        public Student Student { get; set; }
        public TeacherOfStudent TeacherOfStudent { get; set; }
    }
}
