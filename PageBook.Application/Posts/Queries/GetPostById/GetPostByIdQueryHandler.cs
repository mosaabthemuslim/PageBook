using AutoMapper;
using MediatR;
using PageBook.Application.Posts.Dtos;
using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;

namespace PageBook.Application.Posts.Queries.GetPostById;

public class GetPostByIdQueryHandler(IPostRepository postRepository, IMapper mapper) : IRequestHandler<GetPostByIdQuery, PostDto>
{
    public async Task<PostDto> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
    {

        var post = await postRepository.GetPostByIdAsync(request.Id);

        if (post == null)
        {
            throw new Exception(nameof(Post) + " not found");
        }


        var postDto = mapper.Map<PostDto>(post);
        return postDto;
    }
}
