using Microsoft.EntityFrameworkCore;
using System;

namespace Task11.Models
{
    public class MyDbContext :DbContext
    {
        public DbSet <Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.IdPatient).HasName("Patient_PK");
                entity.Property(e =>e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e =>e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e =>e.BirthDate).IsRequired();

            } );

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasKey(e => e.IdPrescription).HasName("Patient_PK");
                
                entity.Property(e => e.Date).HasDefaultValue(DateTime.UtcNow).IsRequired();
                entity.Property(e => e.DueDate).IsRequired();

                entity.HasOne(e => e.Patient)
                .WithMany(d => d.Prescriptions)
                .HasForeignKey(p => p.IdPatient)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("Presciption_Patient_FK");

            });
        }

        }
    }

