namespace ApplicationTracking.Models;

public class JobApplication
{
    public int Id { get; set; }
    public string Company { get; set; }
    public string Position { get; set; }
    public string Status { get; set; } = "Applied";
    public DateTime DateApplied { get; set; } = DateTime.UtcNow;
}