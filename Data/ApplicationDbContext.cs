using Microsoft.EntityFrameworkCore;
//using api_interview.Models;
using api_interview;



namespace api_interview.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizResult> QuizResults { get; set; }
    }
}