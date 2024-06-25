using System;
using System.Linq;
using System.Threading.Tasks;
using api_interview.Data;
//using api_interview.Models;
using Microsoft.EntityFrameworkCore;

namespace api_interview.DataSeeding
{

    public static class QuizSeeder
    {
        private static readonly ApplicationDbContext? _context;

        public static async Task Seed(ApplicationDbContext context)
        {
            if (!context.Quizzes.Any())
            {
                context.Quizzes.AddRange(
                    new Quiz
                    {
                        QuizId = 1,
                        CandidateId = 1,
                        AgentId = 1,
                        Result = 60,
                        CreatedAt = DateTime.Now
                    },
                    new Quiz
                    {
                        QuizId = 2,
                        CandidateId = 2,
                        AgentId = 2,
                        Result = 70,
                        CreatedAt = DateTime.Now
                    }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}