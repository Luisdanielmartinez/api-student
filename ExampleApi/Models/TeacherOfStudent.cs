using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Models
{
    public class TeacherOfStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tell { get; set; }
        //relations
        public int IdentificationCard { get; set; }
        public AddressStudent AddressStudent { get; set; }
    }
}
