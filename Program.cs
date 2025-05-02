using UFAR.UI.Components;  // Make sure you include the namespace for your components and services
using UFAR.PDFSync.Services;  // Ensure you import the namespace for your services
using UFAR.PDFSync.DAO;
using Microsoft.EntityFrameworkCore;

namespace UFAR.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Registering Razor Components
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Register your services (PDF and course parser services)
            builder.Services.AddScoped<IPdfService, PdfService>();  // Register your PDF service
            builder.Services.AddScoped<ICourseParserService, CourseParserService>();  // Register your Course Parser service
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Ensure you don't register services more than once, remove duplicates:
            builder.Services.AddScoped<IPdfParser, PdfParser>(); // if required

            // Register HttpClient with the correct base address
            builder.Services.AddHttpClient("PDFClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7264/");  // Use your actual base URL
            });

            // Default HttpClient registration
            builder.Services.AddHttpClient();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();  // Ensure this is applied in production scenarios
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();  // Serve static files
            app.UseAntiforgery();  // If you're using antiforgery tokens

            // Map Razor Components (Razor Pages with interactive server render mode)
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
