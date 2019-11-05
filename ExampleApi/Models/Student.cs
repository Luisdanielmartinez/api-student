using ExampleApi.Interfaces.InterfaceIEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Models
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string LastName { get; set; }
        [StringLength(30, MinimumLength = 4)]
        public string Andress { get; set; }
        [StringLength(30, MinimumLength = 4)]
        public string Tell { get; set; }
        //relaccion de uno a uno
        public AddressStudent AddressStudent { get; set; }
        public int InstitutionStudentId { get; set; }
        //this is for the relationship 
        public List<TeacherStudent> TeacherStudents { get; set; }
    }
}
