using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GameList.Models;

namespace GameList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GameContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("GameContext")));
        }

    }
}
