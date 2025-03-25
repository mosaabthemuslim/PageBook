using Microsoft.AspNetCore.Identity;

namespace PageBook.Domain.Entities;

public class User : IdentityUser
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public IEnumerable<Post>? Posts { get; set; }
    public IEnumerable<Comment>? Comments { get; set; }
}
