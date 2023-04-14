using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.ProductComponent
{
    public partial class ProductEdit
    {
        [Parameter]
        public int id { get; set; }
        public Product myProduct { get; set; }
        public List<Category> categories { get; set; }
        public List<Supplier> suppliers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //myProduct = await crudProductServ.GetById(id);
            myProduct = await crudProductServ.GetById(id);
            suppliers = await crudSupplierServ.GetAll();// crudSupplierServ.GetAll();
            base.OnInitializedAsync();
        }
        //protected override void OnInitialized()
        //{
        //    myProduct = productServ.getByID(id);
        //    categories = categoryServ.getAll();
        //    //suppliers = crudSupplierServ.GetAll();
        //    base.OnInitialized();
        //}

        public async Task Save()
        {
            //service
            await crudProductServ.Update(id, myProduct);
            Console.WriteLine(myProduct);
            Console.WriteLine("Valid Data SAve Edit ");
            //redirect details
            navManager.NavigateTo("/prodList");
        }
        //public void Save()
        //{
        //    Console.WriteLine(myProduct);
        //    Console.WriteLine("Data SAve Edit ");
        //}
        public void Valid()
        {
            //Console.WriteLine(myProduct);
            Console.WriteLine("Data Is Valid ");
            navManager.NavigateTo($"/pDetail/{id}");
        }
        public void Invalid()
        {
            Console.WriteLine("Data Is INValid ");

        }
    }
}
