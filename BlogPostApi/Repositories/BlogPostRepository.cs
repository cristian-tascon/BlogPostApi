using BlogPostApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPostApi.Repositories
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(TestContext context) : base(context)
        {
        }

    }
}
