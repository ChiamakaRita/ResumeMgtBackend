﻿using Microsoft.EntityFrameworkCore;
using ResumeMgtBackend.Core.Entities;

namespace ResumeMgtBackend.Core.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {  
        }
        public DbSet<Company> companies { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<Candidate> candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>()
                .HasOne(job => job.Company)
                .WithMany(company => company.Jobs)
                .HasForeignKey(job => job.CompanyId);

            modelBuilder.Entity<Candidate>()
                .HasOne(candidate => candidate.Job)
                .WithMany(job => job.Candidates)
                .HasForeignKey(candidate => candidate.JobId);
        }
    }
}
