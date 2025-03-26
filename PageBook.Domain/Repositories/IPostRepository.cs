using PageBook.Domain.Entities;

namespace PageBook.Domain.Repositories;

public interface IPostRepository
{

    Task<Post> GetPostByIdAsync(int id);
    Task<IEnumerable<Post>> GetPostsAsync();
    Task<IEnumerable<Post>> GetPostsByUserIdAsync(string userId);
    Task AddPostAsync(Post post);
    Task UpdatePostAsync(Post post);
    Task DeletePostAsync(Post post);

    Task SaveChanges();




}
