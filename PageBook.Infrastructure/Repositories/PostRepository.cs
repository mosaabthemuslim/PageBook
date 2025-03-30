using Microsoft.EntityFrameworkCore;
using PageBook.Domain.Entities;
using PageBook.Domain.Repositories;
using PageBook.Infrastructure.DataBase;

namespace PageBook.Infrastructure.Repositories;

public class PostRepository(PageBookDbContext context) : IPostRepository
{
    public async Task<int> AddPostAsync(Post post)
    {

        context.Posts.Add(post);
        await context.SaveChangesAsync();
        return post.Id;


    }

    public async Task DeletePostAsync(Post post)
    {

        context.Posts.Remove(post);
        await context.SaveChangesAsync();
    }

    public async Task<Post> GetPostByIdAsync(int id)
    {
        var post = await context.Posts.FirstOrDefaultAsync(x => x.Id == id);
        return post!;
    }

    public async Task<IEnumerable<Post>> GetPostsAsync()
    {
        var posts = await context.Posts.ToListAsync();
        return posts;
    }

    public async Task<IEnumerable<Post>> GetPostsByUserIdAsync(string userId)
    {
        var post = await context.Posts.Where(x => x.UserId == userId).ToListAsync();
        return post;

    }

    public Task SaveChanges()
    {
        return context.SaveChangesAsync();
    }

}
