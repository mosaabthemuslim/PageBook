using System.ComponentModel.DataAnnotations;

namespace PageBook.Domain.Entities;

public class Post
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
    [Required]
    [MaxLength(500)]
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public required string UserId { get; set; }
    public required User User { get; set; }

    public IEnumerable<Comment>? Comments { get; set; }

}
