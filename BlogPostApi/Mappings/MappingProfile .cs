using BlogPostApi.Data.Dto;
using BlogPostApi.Models;
using AutoMapper;


namespace BlogPostApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BlogPost, BlogPostDto>().ReverseMap();
            CreateMap<PostComment, PostCommentDto>().ReverseMap();
        }
    }
}
