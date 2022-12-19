good

[assembly: ApiController]
namespace Hubbix.Batiment.GestionPrestation.API;

internal static class Program
{
  public static void Main(string[] args)
  {
    CreateHostBuilder(args)
      .Build()
      .Initialize()
      .Run();
  }

  public static IHostBuilder CreateHostBuilder(string[] args)
  {
    return Host.CreateDefaultBuilder(args)
      .UseHttp<Startup>();
  }
}