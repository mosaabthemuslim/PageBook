using Microsoft.EntityFrameworkCore;
using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;
using PageBook.Infrastructure.DataBase;

namespace PageBook.Infrastructure.Repositories;

public class CommentRepository(
    PageBookDbContext context

    ) : ICommentRepository
{
    public async Task<int> AddCommentAsync(Comment comment)
    {
        context.Comments.Add(comment);
        await context.SaveChangesAsync();
        return comment.Id;
    }

    public async Task DeleteCommentAsync(Comment comment)
    {

        context.Comments.Remove(comment);
        await context.SaveChangesAsync();

    }

    public Task<Comment> GetCommentByIdAsync(int id)
    {
        var comment = context.Comments.FirstOrDefaultAsync(x => x.Id == id);
        return comment!;
    }

    public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
    {
        var comments = await context.Comments.Where(x => x.PostId == postId).ToListAsync();
        return comments;
    }
}
