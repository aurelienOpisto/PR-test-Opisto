using InterviewLab.Bff.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewLab.Bff.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CandidatesController : ControllerBase
{
    // Intentionally static and mutable for interview discussion.
    private static List<Candidate> _candidates =
    [
        new Candidate { Id = 1, FirstName = "Lina", LastName = "Martin", YearsOfExperience = 3, Skills = ["Angular", "TypeScript"], IsAvailable = true },
        new Candidate { Id = 2, FirstName = "Hugo", LastName = "Bernard", YearsOfExperience = 6, Skills = ["C#", ".NET", "SQL"], IsAvailable = false },
        new Candidate { Id = 3, FirstName = "Nora", LastName = "Petit", YearsOfExperience = 2, Skills = ["Angular", "RxJS"], IsAvailable = true }
    ];

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_candidates);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var found = _candidates.FirstOrDefault(c => c.Id == id);
        if (found == null)
        {
            return NotFound();
        }

        return Ok(found);
    }

    [HttpGet("search")]
    public IActionResult SearchBySkill([FromQuery] string skill)
    {
        // Intentionally naive implementation for interview review.
        var results = _candidates.Where(c => c.Skills.Contains(skill)).ToList();
        return Ok(results);
    }

    [HttpPost]
    public IActionResult Create(Candidate body)
    {
        body.Id = _candidates.Max(c => c.Id) + 1;
        _candidates.Add(body);
        return Ok(body);
    }
}
