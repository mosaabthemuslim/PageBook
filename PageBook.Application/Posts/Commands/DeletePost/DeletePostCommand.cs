using MediatR;

namespace PageBook.Application.Posts.Commands.DeletePost;

public class DeletePostCommand(int Id) : IRequest
{
    public int Id { get; set; } = Id;
}
