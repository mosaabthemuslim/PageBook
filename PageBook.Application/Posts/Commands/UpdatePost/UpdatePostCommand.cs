using MediatR;

namespace PageBook.Application.Posts.Commands.UpdatePost;

public class UpdatePostCommand : IRequest
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
