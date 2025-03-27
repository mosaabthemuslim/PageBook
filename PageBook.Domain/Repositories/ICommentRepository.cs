using PageBook.Domain.Entities;

namespace PageBook.Domain.Repositories;

public interface ICommentRepository
{
    Task<Comment> GetCommentByIdAsync(int id);
    Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);
    Task<int> AddCommentAsync(Comment comment);

    Task DeleteCommentAsync(Comment comment);






}
