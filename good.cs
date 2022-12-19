using Hubbix.Batiment.GestionPrestation.API;
using Microsoft.Extensions.Hosting;

namespace Hubbix.Batiment.GestionPrestation.Consommateur;

public static class Program
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
      .UseMessaging<Startup>();
  }
}