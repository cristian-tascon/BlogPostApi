using BlogPostApi.Data.Dto;
using BlogPostApi.Models;
using BlogPostApi.Repositories;
using AutoMapper;

namespace BlogPostApi.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IMapper _mapper;

        public BlogPostService(IBlogPostRepository blogPostRepository, IMapper mapper)
        {
            _blogPostRepository = blogPostRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BlogPostDto>> GetAllBlogPosts()
        {
            var blogPosts = await _blogPostRepository.GetAll();
            return _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);
        }

        public async Task<BlogPostDto> GetBlogPostById(Guid id)
        {
            var blogPost = await _blogPostRepository.GetById(id);
            return _mapper.Map<BlogPostDto>(blogPost);
        }


        public async Task AddBlogPost(BlogPostDto blogPostDto)
        {
            var blogPost = _mapper.Map<BlogPost>(blogPostDto);
            await _blogPostRepository.Add(blogPost);
        }

        public async Task UpdateBlogPost(BlogPostDto blogPostDto)
        {
            var blogPost = _mapper.Map<BlogPost>(blogPostDto);
            await _blogPostRepository.Update(blogPost);
        }

        public async Task DeleteBlogPost(Guid id)
        {
            await _blogPostRepository.Delete(id);
        }

       
    }
}

