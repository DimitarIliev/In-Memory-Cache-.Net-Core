using In_Memory_Cache.Services;
using Microsoft.AspNetCore.Mvc;

namespace In_Memory_Cache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        public ICategoryService _categoryService { get; set; }
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(Name = "Categories")]
        public List<Category> GetAll()
            => _categoryService.GetCategories();
    }
}
