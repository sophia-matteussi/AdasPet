using AdasPet.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using AdasPet.Services;

namespace AdasPet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Configura os serviços do ASPNET
        // É rodado no começo do programa
        public void ConfigureServices(IServiceCollection services)
        {
            // Padrão
            services.AddDistributedMemoryCache();

            // Adiciona Session ao contexto, permitindo manter dados entre paginas
            services.AddSession(options =>
            {
                // Por quanto tempo guardar a session depois que o usuario fecha o browser
                // Quando expira perde tudo na sessão
                options.IdleTimeout = TimeSpan.FromHours(2);
                // Indica se o cookie pode ser acessado pelo browser/cliente
                options.Cookie.HttpOnly = true;
                // Indica se o cookie é essencial para o funcionamento do site
                options.Cookie.IsEssential = true;
            });

            // Adiciona um contexto de Banco de Dados do EF (Entity Framework)
            services.AddDbContext<ApplicationDbContext>(options =>
                // Indica para o EF que usaremos um SQL Server
                options.UseSqlServer(
                    // Pegamos a ConnectionString do arquivo appsettings.json
                    Configuration.GetConnectionString("DefaultConnection")));

            // Adiciona uma pagina para quando operações no banco de dados dão erro
            services.AddDatabaseDeveloperPageExceptionFilter();

            // Adiciona o identity framework para autenticação e autorização
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                // Adicionamos nosso contexto de BD para o identity guardar suas iniformações
                .AddEntityFrameworkStores<ApplicationDbContext>(); 

            // Adiciona MVC
            services.AddControllersWithViews();

            // Adiciona o Google como forma de login
            services.AddAuthentication()
                .AddGoogle("Google", options =>
                {
                    options.ClientId = "12407940964-80rvesf0pcdqoo9strhe1tjh77qj6a1k.apps.googleusercontent.com";
                    options.ClientSecret = Configuration["GoogleClientSecret"];
                });

            // Adiciona nossa classe de mandar email
            services.AddTransient<IEmailSender, EmailSender>();

            // Padrão
            services.Configure<AuthMessageSenderOptions>(Configuration);

            services.AddAntiforgery(option => option.HeaderName = "X-XSRF-TOKEN");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Se rodar pelo Visual studio adiciona paginos com erros explicattivos
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            // Ativa HTTPS
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Ativa Session
            app.UseSession();

            // Ativa o Identity
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {   
                endpoints.MapControllerRoute(
                    // Diz qual a rota padrão/pagina inicial
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                // Ativa Razor Pages
                endpoints.MapRazorPages();
            });
        }
    }
}
