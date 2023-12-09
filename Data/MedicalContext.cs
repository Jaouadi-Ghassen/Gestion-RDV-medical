using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Medical.Models;

namespace Medical
{
    public class MedicalContext : DbContext
    {
        public MedicalContext (DbContextOptions<MedicalContext> options)
            : base(options)
        {
        }

        public DbSet<Medical.Models.Doctor> Doctor { get; set; } = default!;
        public DbSet<Medical.Models.Appointment> Appointment { get; set; } = default!;
        public DbSet<Medical.Models.Patient> Patient { get; set; } = default!;
        public DbSet<Medical.Models.Prescription> Prescription { get; set; } = default!;
    }
}
