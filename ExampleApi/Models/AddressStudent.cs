using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Models
{
    public class AddressStudent
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string NumHome { get; set; }
        public int StudentId { get; set; }
        public int InstitutionStudentId { get; set; }
    }
}
