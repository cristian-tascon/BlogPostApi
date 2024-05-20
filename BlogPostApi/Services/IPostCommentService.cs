using BlogPostApi.Data.Dto;

namespace BlogPostApi.Services
{
    public interface IPostCommentService
    {
        Task<IEnumerable<PostCommentDto>> GetAllPostComment();
        Task<PostCommentDto> GetPostCommentById(Guid id);
        Task AddPostComment(PostCommentDto postCommentDto);
        Task UpdatePostComment(PostCommentDto postCommentDto);
        Task DeletePostComment(Guid id);
    }
}
