using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PigeonReviewProject.Dto;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Repositories;

namespace PigeonReviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryController(CategoryRepository categoryRepository,
            IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        [HttpGet("GetAll")]
        public IActionResult GetCategory()
        {
            var categories = mapper.Map<List<CategoryDto>>(categoryRepository
                .GetAllCategories());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(categories);
        }
        [HttpGet("GetCategoryById")]
        public IActionResult GetById(int categoryId)
        {
            if (!categoryRepository.CategoryExists(categoryId))
            {
                return NotFound();
            }
            var category = mapper.Map<CategoryDto>(categoryRepository
                .GetCategoryById(categoryId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(category);

        }

        [HttpGet("piegon/{categoryId}")]
        public IActionResult GetPigeosBtCategoryId(int categoryId)
        {
            var piegon = mapper.Map<List<PegionDto>>(categoryRepository
                .GetPigeosBtCategoryId(categoryId));

            if(!ModelState.IsValid)
                return BadRequest(ModelState);


            return Ok(piegon);
        }


    }
}
