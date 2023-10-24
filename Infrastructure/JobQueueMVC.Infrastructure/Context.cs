using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace JobQueueMVC.Infrastracture
{
    public class Context : IdentityDbContext
    {
        private string _connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
        public DbSet<Job> Jobs { get; set; }
        public DbSet<FEAEnginner> FEAEnginners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Type> Types { get;set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<JobTag> JobTag { get; set; }


        public Context(DbContextOptions options) : base(options)
            {   
            }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<JobTag>()
                .HasKey(it => new{ it.JobId, it.TagId});
            
            builder.Entity<JobTag>()
                .HasOne<Job>(it => it.Job)
                .WithMany(t => t.JobTags)
                .HasForeignKey(it => it.JobId);
            
            builder.Entity<JobTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(t => t.JobTags)
                .HasForeignKey(it => it.TagId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }


    }
}