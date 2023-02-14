using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum EGender { Male,Female}
    public enum EHMO { Leumit,Macabi,Mehuchedet,Klalit}

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity  { get; set; }
        public EGender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public EHMO HMO { get; set; }
    }
}
