using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FormDataValidation.Data;
using FormDataValidation.Models;

namespace FormDataValidation.Pages.Register
{
    public class IndexModel : PageModel
    {
        private readonly FormDataValidation.Data.FormDataValidationContext _context;

        public IndexModel(FormDataValidation.Data.FormDataValidationContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration.ToListAsync();
        }
    }
}
