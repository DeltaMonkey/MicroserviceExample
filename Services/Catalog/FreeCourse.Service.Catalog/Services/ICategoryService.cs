using FreeCourse.Service.Catalog.Dtos;
using FreeCourse.Service.Catalog.Models;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Service.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> GetByIdAsync(string id);
        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
    }
}