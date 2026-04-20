using InterviewLab.Bff.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewLab.Bff.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CandidatesController : ControllerBase
{
    private static readonly List<Candidate> Candidates =
    [
        new Candidate { Id = 1, FirstName = "Lina", LastName = "Martin", YearsOfExperience = 3, Skills = ["Angular", "TypeScript"], IsAvailable = true },
        new Candidate { Id = 2, FirstName = "Hugo", LastName = "Bernard", YearsOfExperience = 6, Skills = ["C#", ".NET", "SQL"], IsAvailable = false },
        new Candidate { Id = 3, FirstName = "Nora", LastName = "Petit", YearsOfExperience = 2, Skills = ["Angular", "RxJS"], IsAvailable = true }
    ];

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Candidates);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var found = Candidates.FirstOrDefault(c => c.Id == id);
        if (found == null)
        {
            return NotFound();
        }

        return Ok(found);
    }
}
