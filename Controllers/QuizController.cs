using Microsoft.AspNetCore.Mvc;
using api_interview.Data;
//using api_interview.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_interview.Controllers;

[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public QuizController(ApplicationDbContext context)
    {
        _context = context;
    }
    
}