using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;

namespace PageBook.Infrastructure.Repositories;

public class CommentRepository : ICommentRepository
{
    public Task AddCommentAsync(Comment comment)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCommentAsync(Comment comment)
    {
        throw new NotImplementedException();
    }

    public Task<Comment> GetCommentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCommentAsync(Comment comment)
    {
        throw new NotImplementedException();
    }
}
