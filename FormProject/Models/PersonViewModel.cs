using FormProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormProject.Models
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int StartDate { get; set; }

    }
    public class PersonsViewModel
    {

        public List<Person> Persons { get; set; }

    }

}
