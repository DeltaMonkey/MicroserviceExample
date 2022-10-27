using FreeCourse.Service.Catalog.Dtos;
using FreeCourse.Service.Catalog.Services;
using FreeCourse.Shared.ControllerBases;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Service.Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetByAll() {
            var response = await _categoryService.GetAllAsync();
            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id) {
            var response = await _categoryService.GetByIdAsync(id);
            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto) {
            var response = await _categoryService.CreateAsync(categoryDto);
            return CreateActionResultInstance(response);
        }
    }
}