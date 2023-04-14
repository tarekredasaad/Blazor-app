using BlazorApp1.Data;
using System.Net.Http.Json;
using System.Net.Http;

namespace BlazorApp1.RestFullServices
{
    public class CrudProductServ
    {
        HttpClient httpClient;

        public CrudProductServ()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5122/");
        }
        public async Task<List<Product>> GetAll()
        {
            List<Product> SupList = await httpClient.GetFromJsonAsync<List<Product>>("api/Product");
            return SupList;
        }
        public async Task<Product> GetById(int id)
        {
            Product Product =
                await httpClient.GetFromJsonAsync<Product>
                ($"api/Product/{id}");
            return Product;
        }
        public async Task Update(int id, Product Product)
        {
            await httpClient.PutAsJsonAsync<Product>($"api/Product/{id}", Product);
        }
        public async Task Add(Product Product)
        {
            await httpClient.PostAsJsonAsync<Product>($"api/Product", Product);
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteFromJsonAsync<Product>($"api/Product/{id}");
        }
    }
}
