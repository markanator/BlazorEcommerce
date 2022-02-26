global using BlazorEcommerce.Client.Services.ProductService;
global using BlazorEcommerce.Shared;
global using System.Net.Http.Json;
using BlazorEcommerce.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// add custom services && in _Imports.razor
#region Custom Services
builder.Services.AddScoped<IProductService, ProductService>();

#endregion

await builder.Build().RunAsync();
