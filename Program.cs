using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyEventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<MyEventEase.Services.EventService>();
builder.Services.AddScoped<MyEventEase.Services.UserSessionService>();

builder.Services.AddScoped<IAttendanceService, AttendanceService>();


await builder.Build().RunAsync();
