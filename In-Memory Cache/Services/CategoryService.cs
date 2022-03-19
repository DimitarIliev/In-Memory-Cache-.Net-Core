using In_Memory_Cache.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace In_Memory_Cache.Services
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _categoryRepository;
        private readonly IMemoryCache _memoryCache;
        private const string CategoryCacheKey = "Categories";

        public CategoryService(ICategoryRepository categoryRepository, IMemoryCache memoryCache)
        {
            _categoryRepository = categoryRepository;
            _memoryCache = memoryCache;
        }

        public List<Category> GetCategories()
        {
            var cachedResult = _memoryCache.Get<List<Category>>(CategoryCacheKey);

            if (cachedResult == null)
            {
                var categories = _categoryRepository.GetCategories();

                _memoryCache.Set(CategoryCacheKey, categories);

                return categories;
            }

            return cachedResult;
        }

    }
}
