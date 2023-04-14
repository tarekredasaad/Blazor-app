using BlazorApp1.Data;

namespace BlazorApp1.Services
{
    public class ProductServ
    {
        public List<Product> Products = new List<Product>();
        public ProductServ() 
        {
            Products.Add(new Product { Id = 1, Name = "Dell", Price = 1000,  CategoryId = 1 });
            Products.Add(new Product { Id = 2, Name = "Iphone 6", Price = 2000, CategoryId = 2 });
            Products.Add(new Product { Id = 3, Name = "Watch", Price = 3000, CategoryId = 3 });
            Products.Add(new Product { Id = 4, Name = "Salad", Price = 4000, CategoryId = 4 });
            Products.Add(new Product { Id = 5, Name = "Apple", Price = 1000,  CategoryId = 1 });
            Products.Add(new Product { Id = 6, Name = "Sumsong A22", Price = 2000, CategoryId = 2 });
            Products.Add(new Product { Id = 7, Name = "Ipad", Price = 3000, CategoryId = 3 });
            Products.Add(new Product { Id = 8, Name = "Burger", Price = 4000, CategoryId = 4 });

        }

        public List<Product> getAll()
        {
            return Products;
        }
        public Product getByID(int id)
        {
            return Products.FirstOrDefault(e => e.Id == id);
        }
    }
}
