using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportsStore.Models;

namespace SportsStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;
        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                Configuration["Data:SportStoreProducts:ConnectionString"]));
            //services.AddTransient<IProductRepository, FakeProductRepository>();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {

                // ��ԭ��·������Ļ�����������´��룬����Ӧpageination-8.5Adding Pagingnation--2.Improving the URLs
                routes.MapRoute(
                    name: "pagination",
                    template: "Products/Page{productPage}",
                    defaults: new
                    {
                        Controller = "Product",
                        action = "List"
                    });

                routes.MapRoute(name: "default", template: "{controller=Product}/{action=List}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
