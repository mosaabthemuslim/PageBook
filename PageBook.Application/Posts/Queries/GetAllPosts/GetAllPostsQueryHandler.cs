using AutoMapper;
using MediatR;
using PageBook.Application.Posts.Dtos;
using PageBook.Domain.Repositories;

namespace PageBook.Application.Posts.Queries.GetAllPosts;

public class GetAllPostsQueryHandler(IPostRepository postRepository, IMapper mapper) : IRequestHandler<GetAllPostsQuery, IEnumerable<PostDto>>
{
    public async Task<IEnumerable<PostDto>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
    {


        var posts = await postRepository.GetPostsAsync();
        var postDtos = mapper.Map<IEnumerable<PostDto>>(posts);
        return postDtos;



    }
}
