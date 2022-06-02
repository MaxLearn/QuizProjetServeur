using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace quizExamen.Models
{
    public partial class QuizExamenContext : DbContext
    {
        public QuizExamenContext()
        {
        }

        public QuizExamenContext(DbContextOptions<QuizExamenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ItemOption> ItemOption { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionQuiz> QuestionQuiz { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=QuizExamen");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.AnswerId).HasColumnName("answerID");

                entity.Property(e => e.OptionId).HasColumnName("optionID");

                entity.Property(e => e.QuizId).HasColumnName("quizID");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.OptionId)
                    .HasConstraintName("FK__Answer__optionID__2E1BDC42");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK__Answer__quizID__2F10007B");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK__ItemOpti__3D5DC3C13F06F757");

                entity.Property(e => e.OptionId).HasColumnName("optionID");

                entity.Property(e => e.IsRight).HasColumnName("isRight");

                entity.Property(e => e.QuestionId).HasColumnName("questionID");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ItemOption)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK__ItemOptio__quest__29572725");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId).HasColumnName("questionID");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Question__catego__267ABA7A");
            });

            modelBuilder.Entity<QuestionQuiz>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.QuizId })
                    .HasName("PK__Question__AEC7805311489698");

                entity.Property(e => e.QuestionId).HasColumnName("questionID");

                entity.Property(e => e.QuizId).HasColumnName("quizID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionQuiz)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionQ__quest__31EC6D26");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuestionQuiz)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionQ__quizI__32E0915F");
            });

            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.Property(e => e.QuizId).HasColumnName("quizID");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
