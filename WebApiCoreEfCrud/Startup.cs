using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApiCoreEfCrud.DAL;
using WebApiCoreEfCrud.Interface.DAL;
using WebApiCoreEfCrud.Interface.Service;
using WebApiCoreEfCrud.Service;

namespace WebApiCoreEfCrud
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Esse método é chamado pelo tempo de execução. Use este método para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            //  Serviços
            services.AddScoped<IFuncionarioService, FuncionarioService>();

            // DAL
            services.AddScoped<IFuncionarioDAL, FuncionarioDAL>();

            services.AddMvc();
            services.AddCors();
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(@"Your connection string"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // Esse método é chamado pelo tempo de execução. Use este método para configurar o pipeline de solicitação de HTTP.  
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMiddleware();
            app.UseCors();

            app.UseMvc();
        }
    }
}
