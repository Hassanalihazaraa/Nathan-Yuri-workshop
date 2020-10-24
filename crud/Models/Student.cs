using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using crud.Data;

namespace crud.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public Teacher teacher { get; set; }
        [Required]
        [ForeignKey("TeacherId")]
        public int teacherId { get; set; }
        public IList<Teacher> Teacher { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Teacher = await _context.Teacher
                      .Include(student => student.Teacher)
                      .ToListAsync();
            return Page();
        }
    }  
}