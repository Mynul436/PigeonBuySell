using AutoMapper;
using PigeonReviewProject.Dto;
using PigeonReviewProject.Models;

namespace PigeonReviewProject.MappingHelper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Pigeon, PegionDto>();

            CreateMap<Category, CategoryDto>();

            CreateMap<District,DistrictDto>();

            CreateMap<Owner, OwnerDto>();

            CreateMap<Review, ReviewDto>();

            CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
