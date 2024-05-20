namespace BlogPostApi.Data.Dto
{
    public class PostCommentDto
    {
        public Guid Id { get; set; }
        public Guid BlogPostId { get; set; }
        public string UserFullName { get; set; }
        public string Comment { get; set; }
    }
}
