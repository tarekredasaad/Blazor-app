using BlazorApp1;
using BlazorApp1.Data;
using BlazorApp1.RestFullServices;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Options;

namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped<CategoryServ>();
            builder.Services.AddScoped<ProductServ>();
            builder.Services.AddScoped<CrudSupplierServ>();
            builder.Services.AddScoped<CrudProductServ>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddHttpClient<IServices<Product>, CrudProductServ>(
            //   options =>
            //   {
            //       options.BaseAddress =
            //       new Uri(builder.Configuration["ipApi"].ToString());
            //   });
            //builder.Services.AddHttpClient<IServices<Supplier>, CrudSupplierServ>(
            //    options =>
            //    {
            //        options.BaseAddress =
            //        new Uri(builder.Configuration["ipApi"].ToString());
            //    });
            await builder.Build().RunAsync();
        }
    }
}