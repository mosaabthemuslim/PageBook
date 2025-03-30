using AutoMapper;
using MediatR;
using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;

namespace PageBook.Application.Posts.Commands.UpdatePost;

public class UpdatePostCommandHandler(IPostRepository postRepository, IMapper mapper) : IRequestHandler<UpdatePostCommand>
{
    public async Task Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        var post = await postRepository.GetPostByIdAsync(request.Id);
        if (post == null)
        {
            throw new Exception(nameof(Post) + " not found");
        }

        mapper.Map(request, post);
        post.UpdatedAt = DateTime.Now;
        await postRepository.SaveChanges();
    }
}
