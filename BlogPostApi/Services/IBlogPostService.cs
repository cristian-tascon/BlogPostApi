using BlogPostApi.Data.Dto;

namespace BlogPostApi.Services
{
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPostDto>> GetAllBlogPosts();
        Task<BlogPostDto> GetBlogPostById(Guid id);
        Task AddBlogPost(BlogPostDto blogPostDto);
        Task UpdateBlogPost(BlogPostDto blogPostDto);
        Task DeleteBlogPost(Guid id);
    }
}
