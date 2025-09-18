namespace ApplicationTracking.DTOs;

public class JobApplicationDTO
{
    public string Company { get; set; }
    public string Position { get; set; }
    public string Status { get; set; } = "Applied";
}