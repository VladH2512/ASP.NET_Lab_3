using ASP.NET_Lab_3.Data.Interfaces;
using ASP.NET_Lab_3.Data;
using ASP.NET_Lab_3.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Lab_3
{

    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(Microsoft.Extensions.Hosting.IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAllClothes, ClothesRepository>();
            services.AddTransient<IClothesCategory, CategoryRepository>();
            services.AddTransient<IClothesTypes, TypesRepository>();
            services.AddTransient<IClothesCompany, CompanyRepository>();
            services.AddTransient<IClothesColor, ColorRepository>();

            services.AddMvc(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }

            //����������� �������
            app.UseDeveloperExceptionPage();

            app.UseStatusCodePages();//����������� ���� �������

            //��� ����������� ����� �����, ����� �� ����������, css-����� �� ����
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute(); //��� ������������� �� ������������

        }

    }
}
