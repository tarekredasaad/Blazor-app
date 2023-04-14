using BlazorApp1.Data;
using BlazorApp1.Services;

namespace BlazorApp1.CategoryComponents
{
    public class CategoryComp
    {
        public CategoryComp()
        {
            categoryServ = new CategoryServ();
            Categories = new List<Category>();
        }
        public List<Category> Categories { get; set; }
        public CategoryServ categoryServ { get; set; }
        protected  void fill()
        {
            Categories = categoryServ.getAll();
        }  
    }
}
