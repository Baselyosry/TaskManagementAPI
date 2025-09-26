using TaskManagementAPI.Models.Foundations.Tasks;
using TaskManagementAPI.Models.Foundations.Teams;

namespace TaskManagementAPI.Models.Foundations.Projects;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }

    public ICollection<TodoTask> TodoTasks { get; set; }
    public ICollection<Team> Teams { get; set; }
}