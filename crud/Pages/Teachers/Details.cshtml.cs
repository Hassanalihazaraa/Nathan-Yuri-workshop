using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud.Data;
using crud.Models;

namespace crud.Pages.Teachers
{
    public class DetailsModel : PageModel
    {
        private readonly crud.Data.CrudDbContext _context;

        public DetailsModel(crud.Data.CrudDbContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.id == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
