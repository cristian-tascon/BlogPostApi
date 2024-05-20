namespace BlogPostApi.Data.Dto
{
    public class BlogPostDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public List<PostCommentDto> Comments { get; set; }
    }
}
