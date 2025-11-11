using Microsoft.EntityFrameworkCore;
using StackOverflowClone.Models;

namespace StackOverflowClone.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                        .HasMany(q => q.Answers)
                        .WithOne(a => a.Question)
                        .HasForeignKey(a => a.QuestionId);

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Title = "What is ASP.NET Core?",
                    Body = "Explain ASP.NET Core.",
                    PostedBy = "Mobinul Ahasan Tanjid",
                    PostedDate = new DateTime(2025, 11, 10)
                },
                new Question
                {
                    Id = 2,
                    Title = "What is EF Core?",
                    Body = "Explain EF Core.",
                    PostedBy = "Mohammad Shakil",
                    PostedDate = new DateTime(2025, 11, 10)
                },
                new Question
                {
                    Id = 3,
                    Title = "What is Dependency Injection in .NET?",
                    Body = "Describe the concept of Dependency Injection and how it is implemented in ASP.NET Core.",
                    PostedBy = "Joy Datta",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 4,
                    Title = "What is Middleware in ASP.NET Core?",
                    Body = "Explain what middleware is and how it works in the request pipeline.",
                    PostedBy = "Rahmatullah Rony",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 5,
                    Title = "What is Clean Architecture?",
                    Body = "Discuss the layers and benefits of using Clean Architecture in .NET applications.",
                    PostedBy = "Simanta Saha",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 6,
                    Title = "What is Entity Framework Core Migration?",
                    Body = "Explain how EF Core Migrations help in database versioning and schema updates.",
                    PostedBy = "Mohammmad Noor",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 7,
                    Title = "What are Controllers in ASP.NET Core MVC?",
                    Body = "Describe the role of controllers and actions in handling HTTP requests.",
                    PostedBy = "MD Abu Taseen",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 8,
                    Title = "What is the difference between .NET Framework and .NET Core?",
                    Body = "Highlight the key differences between .NET Framework and .NET Core.",
                    PostedBy = "Mobinul Ahasan Tanjid",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 9,
                    Title = "What are DTOs in Web API?",
                    Body = "Explain why Data Transfer Objects are used and how they improve API design.",
                    PostedBy = "Mohammad Shakil",
                    PostedDate = new DateTime(2025, 11, 11)
                },
                new Question
                {
                    Id = 10,
                    Title = "What is Routing in ASP.NET Core?",
                    Body = "Explain attribute routing and conventional routing with examples.",
                    PostedBy = "Joy Datta",
                    PostedDate = new DateTime(2025, 11, 11)
                }
            );

        }
    }
}
