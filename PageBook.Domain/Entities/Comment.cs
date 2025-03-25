using System.ComponentModel.DataAnnotations;

namespace PageBook.Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    [Required]
    [MaxLength(500)]
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    [Required]
    public required string UserId { get; set; }
    [Required]
    public required User User { get; set; }
    [Required]
    public int PostId { get; set; }
    [Required]
    public required Post Post { get; set; }
}
