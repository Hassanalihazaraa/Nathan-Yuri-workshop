namespace crud.Models
{
    public class Teacher
    {
        [ForeignKey("TeacherID")]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
}