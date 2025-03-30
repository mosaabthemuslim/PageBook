using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;

namespace PageBook.Application.Posts.Commands.CreatePost;

public class CreatePostCommandHandler(
    IPostRepository postRepository,
    IMapper mapper,
    IHttpContextAccessor httpContextAccessor,
    UserManager<User> userManager,
    ILogger<CreatePostCommandHandler> logger

    ) : IRequestHandler<CreatePostCommand, int>
{
    public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        var currentUserId = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
        if (currentUserId == null)
        {
            throw new UnauthorizedAccessException();
        }
        logger.LogInformation("User {UserId} is creating a new post", currentUserId.Id);
        var post = mapper.Map<Post>(request);
        post.UserId = currentUserId.Id.ToString();
        post.CreatedAt = DateTime.Now;
        var postId = await postRepository.AddPostAsync(post);
        return postId;

    }
}
