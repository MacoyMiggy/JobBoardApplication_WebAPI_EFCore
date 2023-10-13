// DBContext and DBSet for Applicant and Job Position

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace JobBoardApplication_WebAPI_EFCore.Models;

public partial class JobBoardAppWebApiContext : DbContext
{
    public JobBoardAppWebApiContext()
    {
    }

    public JobBoardAppWebApiContext(DbContextOptions<JobBoardAppWebApiContext> options)
        : base(options)
    {
        //Database.EnsureCreated();
    }

    public virtual DbSet<Applicant> Applicants { get; set; }

    public virtual DbSet<JobPosition> JobPositions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JobBoardApp_WebAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Applicant>(entity =>
        {
            entity.HasKey(e => e.ApplicantId).HasName("PK__Applican__39AE91A88E0F09FE");

            entity.ToTable("Applicant");

            entity.Property(e => e.ApplicantId).ValueGeneratedNever();
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.JobPosition)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<JobPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobPosit__3214EC0788B78676");

            entity.ToTable("JobPosition");
            entity.Property(e => e.ApplicantId).ValueGeneratedNever();
            entity.Property(e => e.WorkPosition)
                .HasMaxLength(20)
            .IsFixedLength();
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
