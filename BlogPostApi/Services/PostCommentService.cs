using BlogPostApi.Data.Dto;
using BlogPostApi.Models;
using BlogPostApi.Repositories;
using AutoMapper;

namespace BlogPostApi.Services
{
    public class PostCommentService : IPostCommentService
    {
        private readonly IPostCommentRepository _postCommentRepository;
        private readonly IMapper _mapper;

        public PostCommentService(IPostCommentRepository postCommentRepository, IMapper mapper)
        {
            _postCommentRepository = postCommentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostCommentDto>> GetAllPostComment()
        {
            var postComment = await _postCommentRepository.GetAll();
            return _mapper.Map<IEnumerable<PostCommentDto>>(postComment);
        }

        public async Task<PostCommentDto> GetPostCommentById(Guid id)
        {
            var postComment = await _postCommentRepository.GetById(id);
            return _mapper.Map<PostCommentDto>(postComment);
        }

        public async Task AddPostComment(PostCommentDto postCommentDto)
        {
            var postComment = _mapper.Map<PostComment>(postCommentDto);
            await _postCommentRepository.Add(postComment);
        }

        public async Task UpdatePostComment(PostCommentDto postCommentDto)
        {
            var postComment = _mapper.Map<PostComment>(postCommentDto);
            await _postCommentRepository.Update(postComment);
        }

        public async Task DeletePostComment(Guid id)
        {
            await _postCommentRepository.Delete(id);
        }
    }
}
