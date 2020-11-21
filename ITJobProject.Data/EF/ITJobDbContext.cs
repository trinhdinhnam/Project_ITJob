using ITJobProject.Data.Configurations;
using ITJobProject.Data.Entities;
using ITJobProject.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITJobProject.Data.EF
{
    public class ITJobDbContext : DbContext
    {
        public ITJobDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configre using Fluent API
            modelBuilder.ApplyConfiguration(new AdminConfigguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new RecruiterConfiguration());
            modelBuilder.ApplyConfiguration(new RecruiterLevelConfiguration());
            modelBuilder.ApplyConfiguration(new SeekerConfiguration());
            modelBuilder.ApplyConfiguration(new SeekerJobConfiguration());

            //base.OnModelCreating(modelBuilder);
            //Seed 
            modelBuilder.Seed();
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<SeekerJob> RecruiterLevels { get; set; }
        public DbSet<SeekerJob> Seekers { get; set; }
        public DbSet<SeekerJob> SeekerJobs { get; set; }

    }
}
