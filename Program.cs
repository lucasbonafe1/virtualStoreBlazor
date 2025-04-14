using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VirtualStoreMacoratti;
using VirtualStoreMacoratti.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<VirtualStoreMacoratti.Web.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string baseUrl = "https://localhost:7055";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl) });
builder.Services.AddScoped<IProdutoService, ProdutoService>();
await builder.Build().RunAsync();
