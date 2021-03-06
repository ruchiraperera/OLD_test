﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Create_WebApps_in_Core.Models;

namespace Create_WebApps_in_Core.Pages.StudentView
{
    public class DetailsModel : PageModel
    {
        private readonly Create_WebApps_in_Core.Models.DatabaseContext _context;

        public DetailsModel(Create_WebApps_in_Core.Models.DatabaseContext context)
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

            Student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
