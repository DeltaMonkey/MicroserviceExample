using Microsoft.AspNetCore.Mvc;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Service.Catalog.Services;
using FreeCourse.Service.Catalog.Dtos;

namespace FreeCourse.Service.Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : CustomBaseController
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService) {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var response = await _courseService.GetAllAsync();
            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id) {
            var response = await _courseService.GetByIdAsync(id);
            return CreateActionResultInstance(response);
        }

        //relative path dene
        [HttpGet("GetByUserId/{userId}")]
        public async Task<IActionResult> GetByUserId(string userId) {
            var response = await _courseService.GetByUserIdAsync(userId);
            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto courseCreateDto) {
            var response = await _courseService.CreateAsync(courseCreateDto);
            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDto courseUpdateDto) {
            var response = await _courseService.UpdateAsync(courseUpdateDto);
            return CreateActionResultInstance(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Dekete(string id) {
            var response = await _courseService.DeleteAsync(id);
            return CreateActionResultInstance(response);
        }

    }
}