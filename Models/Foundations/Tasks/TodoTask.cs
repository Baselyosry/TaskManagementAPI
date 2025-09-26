using TaskManagementAPI.Models.Foundations.Projects;

namespace TaskManagementAPI.Models.Foundations.Tasks;

public class TodoTask
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset DueDate { get; set; }
    public bool IsCompleted { get; set; }
    
    public Guid ProjectId { get; set; }
    public Project Project { get; set; }
}