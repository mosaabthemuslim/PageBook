using MediatR;
using PageBook.Application.Posts.Dtos;

namespace PageBook.Application.Posts.Queries.GetPostById;

public class GetPostByIdQuery(int Id) : IRequest<PostDto>
{
    public int Id { get; set; } = Id;
}
