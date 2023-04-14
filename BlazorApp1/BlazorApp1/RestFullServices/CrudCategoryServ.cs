using BlazorApp1.Data;
    using System.Net.Http.Json;
using System.Net.Http;
namespace BlazorApp1.RestFullServices
{
    public class CrudCategoryServ
    {
        HttpClient httpClient;
        public CrudCategoryServ()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("");
        }
        //public async Task<List<Category>> GetAll()
        //{
        //List<Category> SupList = await httpClient.GetFromJsonAsync<List<Category>>("api/Categorys");
        //    return SupList;
        //}
        //public async Task<Category> GetById(int id)
        //{
        //    Category Category =
        //        await httpClient.GetFromJsonAsync<Category>
        //        ($"api/Categorys/{id}");
        //    return Category;
        //}
        //public async Task Update(int id, Category Category)
        //{
        //    await httpClient.PutAsJsonAsync<Category>($"api/Categorys/{id}", Category);
        //}
        //public async Task Add(Category Category)
        //{
        //    await httpClient.PostAsJsonAsync<Category>($"api/Categorys", Category);
        //}
        //public async Task Delete(int id)
        //{
        //    await httpClient.DeleteFromJsonAsync<Category>($"api/Categorys/{id}");
        //}
        //
    }
}
