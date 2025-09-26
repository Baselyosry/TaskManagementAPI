using Microsoft.AspNetCore.Identity;
using TaskManagementAPI.Models.Foundations.Tasks;
using TaskManagementAPI.Models.Foundations.Teams;

namespace TaskManagementAPI.Models.Foundations.Users;

public class User : IdentityUser<Guid>
{
    public override Guid Id
    {   
        get => base.Id;
        set => base.Id = value;
    }

    public ICollection<TodoTask> TodoTasks { get; set; }
    public ICollection<Team> Teams { get; set; }

}