using BlazorApp1.Data;
using System.Net.Http.Json;
using System.Net.Http;
//using BlazorApp1.Data;
//using System.Net.Http.Json;//using System.Net.Http.Json;

namespace BlazorApp1.RestFullServices
{
    public class CrudSupplierServ
    {
        HttpClient httpClient;
        public CrudSupplierServ()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5122/");
        }
        public async Task<List<Supplier>> GetAll()
        {
        List<Supplier> SupList = await httpClient.GetFromJsonAsync<List<Supplier>>("api/Supplier");
            return SupList;
        }
        public async Task<Supplier> GetById(int id)
        {
            Supplier supplier =
                await httpClient.GetFromJsonAsync<Supplier>
                ($"api/Supplier/{id}");
            return supplier;
        }
        public async Task Update(int id, Supplier supplier)
        {
            await httpClient.PutAsJsonAsync<Supplier>($"api/Supplier/{id}", supplier);
        }
        public async Task Add(Supplier supplier)
        {
            await httpClient.PostAsJsonAsync<Supplier>($"api/Supplier", supplier);
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteFromJsonAsync<Supplier>($"api/Supplier/{id}");
        }

    }
}
