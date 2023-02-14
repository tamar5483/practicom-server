namespace MyProject.WebAPI.Models
{
    public class ChildModel
    {

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Identity { get; set; }
        public int Parent1Id { get; set; }
        public int? Parent2Id { get; set; }
    }
}
