using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud.Data;
using crud.Models;

namespace crud.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly crud.Data.CrudDbContext _context;

        public DetailsModel(crud.Data.CrudDbContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student
                .Include(s => s.teacher).FirstOrDefaultAsync(m => m.id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
