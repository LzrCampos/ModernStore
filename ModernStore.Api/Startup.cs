using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ModernStore.Infrastructure.Contexts;
using ModernStore.Infrastructure.Repositories;
using ModernStore.Infrastructure.Transaction;
using MordenStore.Domain.Repositories;

namespace ModernStore.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddJsonFormatters();
            services.AddCors();
            

            services.AddScoped<ModernStoreDataContext, ModernStoreDataContext>();
            services.AddTransient<IUow, Uow>();

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepositoriy>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });

            app.UseMvc();
        }
    }
}
