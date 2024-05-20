using BlogPostApi.Data.Dto;
using BlogPostApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BlogPostDto>>> GetAllBlogPosts()
        {
            var blogPosts = await _blogPostService.GetAllBlogPosts();
            return Ok(blogPosts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPostDto>> GetBlogPostById(Guid id)
        {
            var blogPost = await _blogPostService.GetBlogPostById(id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return Ok(blogPost);
        }

       

        [HttpPost]
        public async Task<ActionResult> AddBlogPost(BlogPostDto blogPostDto)
        {
            await _blogPostService.AddBlogPost(blogPostDto);
            return CreatedAtAction(nameof(GetBlogPostById), new { id = blogPostDto.Id }, blogPostDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBlogPost(Guid id, BlogPostDto blogPostDto)
        {
            if (id != blogPostDto.Id)
            {
                return BadRequest();
            }

            await _blogPostService.UpdateBlogPost(blogPostDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBlogPost(Guid id)
        {
            await _blogPostService.DeleteBlogPost(id);
            return NoContent();
        }
    }
}

