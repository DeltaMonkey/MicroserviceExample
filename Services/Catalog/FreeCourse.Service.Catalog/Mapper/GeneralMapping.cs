using AutoMapper;
using FreeCourse.Service.Catalog.Dtos;
using FreeCourse.Service.Catalog.Models;

namespace FreeCourse.Service.Catalog.Mapper
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping() {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();
        }
    }
}