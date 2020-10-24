using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using crud.Data;
using crud.Models;

namespace crud.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly crud.Data.CrudDbContext _context;

        public CreateModel(crud.Data.CrudDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["teacherId"] = new SelectList(_context.Teacher, "id", "id");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
