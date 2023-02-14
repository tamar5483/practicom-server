using MyProject.Repositories.Entities;

namespace MyProject.WebAPI.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string HMO { get; set; }
    }
}
