using BlazorApp1.Data;

namespace BlazorApp1.CategoryComponents
{
    public partial class CategoryEdit
    {
        public Category myCategory { get; set; }

        protected override void OnInitialized()
        {
            myCategory = categoryServ.getById(id);
            base.OnInitialized();
        }
        public void Save()
        {
            Console.WriteLine(myCategory);
            Console.WriteLine("Data SAve Edit ");
        }
    }
}
