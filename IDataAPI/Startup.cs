using IDataAPI.Controls.Counters;
using IDataAPI.Interfaces.Calculators;
using IDataAPI.Interfaces.Counters;
using IDataAPI.Models;
using IDataAPI.Services.Calculators;
using IDataAPI.Services.Counters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IDataAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            string connection = Configuration.GetSection("ConnectionStrings:IData").Value;
            services.AddDbContext<IDataContext>(options => options.UseSqlServer(connection));

            services.AddTransient<IPuzzles, PuzzlesService>();
            services.AddScoped<IScopedCounter, ScopedCounter>();
            services.AddTransient<ITransientCounter, TransientCounter>();
            services.AddSingleton<ISingletonCounter, SingletonCounter>();
            services.AddTransient<TestDILifeTimeService, TestDILifeTimeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowAnyOrigin();
            });

            app.UseMvc();
        }
    }
}
