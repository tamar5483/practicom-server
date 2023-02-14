using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Child
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Identity { get; set; }
        public int MyProperty { get; set; }
        public int Parent1Id { get; set; }
        public User Parent1 { get; set; }
        public int? Parent2Id { get; set; }
        public User? Parent2 { get; set; }
    }
}
