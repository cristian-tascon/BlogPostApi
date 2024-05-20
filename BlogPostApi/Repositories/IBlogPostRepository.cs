using BlogPostApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPostApi.Repositories
{
    public interface IBlogPostRepository : IRepository<BlogPost>
    {
    }
}
