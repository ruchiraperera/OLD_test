using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Create_WebApps_in_Core.Models;

namespace Create_WebApps_in_Core.Pages.StudentView
{
    public class IndexModel : PageModel
    {
        private readonly Create_WebApps_in_Core.Models.DatabaseContext _context;

        public IndexModel(Create_WebApps_in_Core.Models.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
