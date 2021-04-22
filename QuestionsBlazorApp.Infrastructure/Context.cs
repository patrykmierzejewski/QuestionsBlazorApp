using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuestionsBlazorApp.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsBlazorApp.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserAnswer> UserAnswer { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many answers to 1 questions
            modelBuilder.Entity<Question>()
                .HasMany(m => m.AnswersList)
                .WithOne(l => l.Question);
                //.HasForeignKey(f => f.QuestionId);

            modelBuilder.Entity<UserAnswer>()
                .HasOne(x => x.Answer);
            modelBuilder.Entity<UserAnswer>()
                .HasOne(x => x.User);
            modelBuilder.Entity<UserAnswer>()
               .HasOne(x => x.Question);
        }


        //private string _connectionString = "";
        ///// <summary>
        ///// Connect to database test
        ///// </summary>
        ///// <param name="optionsBuilder"></param>
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
