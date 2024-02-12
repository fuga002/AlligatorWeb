using AlligatorWeb;
using AlligatorWeb.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<TelegramBotService>(sp =>
{
    // Replace these values with your actual bot token and chat ID
    string botToken = "6610856434:AAEM_rbSBsWmBS5CJjRcmv_TY1fXO3uJ5bM";
    long chatId = -4187682426;
    return new TelegramBotService(botToken, chatId);
});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
