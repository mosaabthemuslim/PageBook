using MediatR;

namespace PageBook.Application.Posts.Commands.CreatePost;

public class CreatePostCommand : IRequest<int>
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string UserId { get; set; } = string.Empty;
}
