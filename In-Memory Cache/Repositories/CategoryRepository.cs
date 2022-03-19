namespace In_Memory_Cache.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Name = "Music", Description = "Best music for you to listen to"},
                new Category { Name = "Movies", Description = "Watch the top movies in the world"},
                new Category { Name = "Games", Description = "Best selling games right not"}
            };
        }
    }
}
