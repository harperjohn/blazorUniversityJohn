using CustomValidation.Validators;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomValidation
{
	public static class Program
	{
		public async static Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");
			builder.Services.AddScoped<PersonValidator>();

			await builder.Build().RunAsync();
		}
	}
}
