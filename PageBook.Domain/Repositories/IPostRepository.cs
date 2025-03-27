using PageBook.Domain.Entities;

namespace PageBook.Domain.Repositories;

public interface IPostRepository
{

    Task<Post> GetPostByIdAsync(int id);
    Task<IEnumerable<Post>> GetPostsAsync();
    Task<IEnumerable<Post>> GetPostsByUserIdAsync(string userId);
    Task<int> AddPostAsync(Post post);
    Task DeletePostAsync(Post post);

    Task SaveChanges();




}
