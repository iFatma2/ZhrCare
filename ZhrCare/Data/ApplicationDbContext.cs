using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZhrCare.Models;

namespace ZhrCare.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser> 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Routine> Routines { get; set; }
    
    public DbSet<Medication> Medications { get; set; }
    public DbSet<MedicationLog> MedicationLogs { get; set; }
}