using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ChildDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Identity { get; set; }
        public int Parent1Id { get; set; }
        public UserDTO Parent1 { get; set; }
        public int? Parent2Id { get; set; }
        public UserDTO Parent2 { get; set; }
    }
}
