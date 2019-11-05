using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Models
{
    public class InstitutionStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //relaccion de uno a muchos con estudiantes
        public List<Student> ListStudent { get; set; }
        //relacion uno a uno con direccion
        public AddressStudent AddressStudent { get; set; }
    }
}
