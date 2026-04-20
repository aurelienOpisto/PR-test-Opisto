namespace InterviewLab.Bff.Models;

public class Candidate
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int YearsOfExperience { get; set; }
    public string[] Skills { get; set; } = [];
    public bool IsAvailable { get; set; }
}
