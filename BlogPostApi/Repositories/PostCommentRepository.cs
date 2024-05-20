using BlogPostApi.Models;

namespace BlogPostApi.Repositories
{
    public class PostCommentRepository : Repository<PostComment>, IPostCommentRepository
    {
        public PostCommentRepository(TestContext context) : base(context)
        {
        }
    }
}
