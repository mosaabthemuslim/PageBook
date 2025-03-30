using MediatR;
using Microsoft.AspNetCore.Http;
using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;
using System.Security.Claims;

namespace PageBook.Application.Posts.Commands.DeletePost;

public class DeletePostCommandHandler(IPostRepository postRepository, IHttpContextAccessor httpContextAccessor) : IRequestHandler<DeletePostCommand>
{
    public async Task Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {

        var post = await postRepository.GetPostByIdAsync(request.Id);
        if (post == null)
        {
            throw new Exception(nameof(Post) + " not found");
        }
        var currentUserId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (currentUserId == null || post.UserId != currentUserId)
        {
            throw new UnauthorizedAccessException();
        }
        await postRepository.DeletePostAsync(post);




    }
}
