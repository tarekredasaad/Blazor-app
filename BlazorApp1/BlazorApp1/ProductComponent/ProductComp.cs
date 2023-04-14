using BlazorApp1.Services;
using BlazorApp1.Data;

namespace BlazorApp1.ProductComponent
{
    public class ProductComp
    {
        public ProductComp()
        {
            Products = new List<Product>();

            productServ = new ProductServ(); 
        }
        public List<Product> Products { get; set; }
        public ProductServ productServ { get; set; }
        protected  void fill()
        {
            Products = productServ.getAll();
        }
    }
}
