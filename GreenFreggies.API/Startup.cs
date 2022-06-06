using GreenFreggies.API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using GreenFreggies.API.Repository;
using GreenFreggies.API.Services;

namespace GreenFreggies.API
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
            services.AddDbContext<VegetablesDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));
            //User
            services.AddTransient<IUserDetails, UserDetails>();
            services.AddTransient<UserDetailsServices, UserDetailsServices>();
            //Cart
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<CartServices, CartServices>();
            //Order
            services.AddTransient<IOrderDetails, OrderDetailsRepository>();
            services.AddTransient<orderDetailsServices, orderDetailsServices>();
            //Vegetable
            services.AddTransient<IVegetable, Vegetable>();
            services.AddTransient<VegetableServices, VegetableServices>();
            //Transaction
            services.AddTransient<ITransaction, TransactionRepository>();
            services.AddTransient<TransactionRepository, TransactionRepository>();
            //Feedback
            services.AddTransient<IFeedback, FeedbackDetails>();
            services.AddTransient<FeedbackService, FeedbackService>();
            services.AddCors();
            services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(
                options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GreenFreggies.API", Version = "v1" });
            });

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GreenFreggies.API v1"));
            }

            app.UseHttpsRedirection();
           
            app.UseRouting();
            
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
