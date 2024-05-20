using BlogPostApi.Data.Dto;
using BlogPostApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {
        private readonly IPostCommentService _postCommentService;

        public PostCommentController(IPostCommentService postCommentService)
        {
            _postCommentService = postCommentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostCommentDto>>> GetAllPostComment()
        {
            var postComment = await _postCommentService.GetAllPostComment();
            return Ok(postComment);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostCommentDto>> GetPostCommentById(Guid id)
        {
            var postComment = await _postCommentService.GetPostCommentById(id);
            if (postComment == null)
            {
                return NotFound();
            }
            return Ok(postComment);
        }

        [HttpPost]
        public async Task<ActionResult> AddPostComment(PostCommentDto postCommentDto)
        {
            await _postCommentService.AddPostComment(postCommentDto);
            return CreatedAtAction(nameof(GetPostCommentById), new { id = postCommentDto.Id }, postCommentDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePostComment(Guid id, PostCommentDto postCommentDto)
        {
            if (id != postCommentDto.Id)
            {
                return BadRequest();
            }

            await _postCommentService.UpdatePostComment(postCommentDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePostComment(Guid id)
        {
            await _postCommentService.DeletePostComment(id);
            return NoContent();
        }
    }
}
