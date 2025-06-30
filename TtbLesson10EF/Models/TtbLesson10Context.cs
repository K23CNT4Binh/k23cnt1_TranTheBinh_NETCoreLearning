using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TtbLesson10EF.Models;

public partial class TtbLesson10Context : DbContext
{
    public TtbLesson10Context()
    {
    }

    public TtbLesson10Context(DbContextOptions<TtbLesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TtbPost> TtbPosts { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-FDB7IL1\\MAY01;Database=TtbK23CNT1_Lesson10db;User Id=sa;Password=binh27062005;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TtbPost>(entity =>
        {
            entity.HasKey(e => e.Ttbid);

            entity.ToTable("TtbPost");

            entity.Property(e => e.Ttbid).HasColumnName("ttbid");
            entity.Property(e => e.TtbContent)
                .HasColumnType("ntext")
                .HasColumnName("ttbContent");
            entity.Property(e => e.TtbImages)
                .HasMaxLength(250)
                .HasColumnName("ttbImages");
            entity.Property(e => e.TtbStatus).HasColumnName("ttbStatus");
            entity.Property(e => e.TtbTitle)
                .HasMaxLength(250)
                .HasColumnName("ttbTitle");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
