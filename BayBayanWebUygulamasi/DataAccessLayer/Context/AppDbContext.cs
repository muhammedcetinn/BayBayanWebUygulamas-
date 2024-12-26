using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // PersonnelService Configurations
            builder.Entity<PersonnelService>()
                .HasKey(ps => ps.Id);
            builder.Entity<PersonnelService>()
                .HasOne(ps => ps.CoiffeurService)
                .WithMany(cs => cs.PersonnelServices)
                .HasForeignKey(ps => ps.CoiffeurServiceId);
            builder.Entity<PersonnelService>()
                .HasOne(ps => ps.Personnel)
                .WithMany(p => p.PersonnelServices)
                .HasForeignKey(ps => ps.PersonnelId);
            builder.Entity<PersonnelService>()
                .Property(ps => ps.Price)
                .HasColumnType("decimal(18,2)");

            // PersonnelInfo Configurations
            builder.Entity<PersonnelInfo>()
                .HasKey(pi => pi.Id);
            builder.Entity<PersonnelInfo>()
                .HasOne(pi => pi.Personnel)
                .WithMany(p => p.PersonnelInfos)
                .HasForeignKey(pi => pi.PersonnelId);
            builder.Entity<PersonnelInfo>()
                .HasOne(pi => pi.CoiffeurShift)
                .WithMany(cs => cs.PersonnelInfos)
                .HasForeignKey(pi => pi.CoiffeurShiftId);

            // Personnel Configurations
            builder.Entity<Personnel>()
                .HasKey(p => p.AppUserId);
            builder.Entity<Personnel>()
                .HasOne(p => p.AppUser)
                .WithOne(au => au.Personnel)
                .HasForeignKey<Personnel>(p => p.AppUserId);

            // CoiffeurShift Configurations
            builder.Entity<CoiffeurShift>()
                .HasKey(cs => cs.Id);
            builder.Entity<CoiffeurShift>()
                .HasOne(cs => cs.Coiffeur)
                .WithMany(c => c.CoiffeurShifts)
                .HasForeignKey(cs => cs.CoiffeurId);

            // CoiffeurService Configurations
            builder.Entity<CoiffeurService>()
                .HasKey(cs => cs.Id);
            builder.Entity<CoiffeurService>()
                .HasOne(cs => cs.Coiffeur)
                .WithMany(c => c.CoiffeurServices)
                .HasForeignKey(cs => cs.CoiffeurId);

            // Coiffeur Configurations
            builder.Entity<Coiffeur>()
                .HasKey(c => c.Id);

            // AppointmentDetail Configurations
            builder.Entity<AppointmentDetail>()
                .HasKey(ad => ad.Id);
            builder.Entity<AppointmentDetail>()
                .HasOne(ad => ad.Appointment)
                .WithMany(a => a.AppointmentDetails)
                .HasForeignKey(ad => ad.AppointmentId);
            builder.Entity<AppointmentDetail>()
                .HasOne(ad => ad.PersonnelService)
                .WithMany(ps => ps.AppointmentDetails)
                .HasForeignKey(ad => ad.PersonnelServiceId)
                .OnDelete(DeleteBehavior.NoAction);

            // Appointment Configurations
            builder.Entity<Appointment>()
                .HasKey(a => a.Id);
            builder.Entity<Appointment>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.CustomerId);
            builder.Entity<Appointment>()
                .Property(a => a.TotalPrice)
                .HasColumnType("decimal(18,2)");
        }
        public DbSet<PersonnelService> PersonnelServices { get; set; }
        public DbSet<PersonnelInfo> PersonnelInfos { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<CoiffeurShift> CoiffeurShifts { get; set; }
        public DbSet<CoiffeurService> CoiffeurServices { get; set; }
        public DbSet<Coiffeur> Coiffeurs { get; set; }
        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
