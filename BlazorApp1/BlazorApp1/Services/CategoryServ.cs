using BlazorApp1.Data;
namespace BlazorApp1.Services
{
    public class CategoryServ
    {
        public List<Category>  categories = new List<Category>();
        public CategoryServ() 
        {
            categories.Add(new Category() { Id = 1, Name = "Laptop" });
            categories.Add(new Category() { Id = 2, Name = "Mobile" });
            categories.Add(new Category() { Id = 3, Name = "Machine" });
            categories.Add(new Category() { Id = 4, Name = "Food" });
        }
        public List<Category> getAll()
        {
            return categories;
        }
        public Category getById(int id)
        {
            return categories.FirstOrDefault(d => d.Id == id);
        }

    }
}
