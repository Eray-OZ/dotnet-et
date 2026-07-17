using Microsoft.Extensions.Configuration;


namespace EtApi.Persistence;

static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EtApi.API/"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("DefaultConnection");
        }
    }
}
