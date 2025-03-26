using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;

namespace PageBook.Infrastructure.Repositories;

public class PostRepository : IPostRepository
{
    public Task AddPostAsync(Post post)
    {
        throw new NotImplementedException();
    }

    public Task DeletePostAsync(Post post)
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetPostByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetPostsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetPostsByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task SaveChanges()
    {
        throw new NotImplementedException();
    }

    public Task UpdatePostAsync(Post post)
    {
        throw new NotImplementedException();
    }
}
