using MediatR;
using PageBook.Application.Posts.Dtos;

namespace PageBook.Application.Posts.Queries.GetAllPosts;

public class GetAllPostsQuery : IRequest<IEnumerable<PostDto>>
{
}
