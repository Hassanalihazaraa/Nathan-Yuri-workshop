namespace DefaultNamespace
{
    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        [ForeignKey("TeacherID")]
        public virtual Teacher teacher { get; set; }
        public int teacherId { get; set; }
    }
}