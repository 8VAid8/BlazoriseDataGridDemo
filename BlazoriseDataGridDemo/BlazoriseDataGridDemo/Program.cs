using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

namespace BlazoriseDataGridDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            object p = builder.Services.AddBlazorise(options =>
            {
                options.ChangeTextOnKeyPress = true;
            })
           .AddBulmaProviders()
           .AddFontAwesomeIcons();

            builder.RootComponents.Add<App>("app");

            var host = builder.Build();

            host.Services.UseBulmaProviders()
            .UseFontAwesomeIcons();

            await host.RunAsync();
        }
    }
}
