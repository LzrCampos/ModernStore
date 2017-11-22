using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ModernStore.Infrastructure.Contexts;
using ModernStore.Infrastructure.Repositories;
using ModernStore.Infrastructure.Services;
using ModernStore.Infrastructure.Transaction;
using MordenStore.Domain.Commands.Handlers;
using MordenStore.Domain.Repositories;
using MordenStore.Domain.Services;
using System.Text;

namespace ModernStore.Api
{
    public class Startup
    {
        private const string ISSUER = "c1f51f42";
        private const string AUDIENCE = "c6bbbb645024";
        private const string SECRET_KEY = "c1f51f42-5727-4d15-b787-c6bbbb645024";

        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRET_KEY));

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddJsonFormatters();
            services.AddCors();
            

            services.AddScoped<ModernStoreDataContext, ModernStoreDataContext>();
            services.AddTransient<IUow, Uow>();

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepositoriy>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<CustomerCommandHandler, CustomerCommandHandler>();
            services.AddTransient<OrderCommandHandler, OrderCommandHandler>();

            services.AddTransient<IEmailService, EmailServices>();
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
