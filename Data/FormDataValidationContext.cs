using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormDataValidation.Models;

namespace FormDataValidation.Data
{
    public class FormDataValidationContext : DbContext
    {
        public FormDataValidationContext (DbContextOptions<FormDataValidationContext> options)
            : base(options)
        {
        }

        public DbSet<FormDataValidation.Models.Registration> Registration { get; set; }
    }
}
