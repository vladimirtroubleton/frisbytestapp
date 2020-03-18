using FrisbiTestApp.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrisbiTestApp.Contexts;
using System.Configuration;

namespace FrisbiTestApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var dbcontext = serviceProvider.GetService<StaffContext>();
                var staffRepository = services.BuildServiceProvider().GetRequiredService<IStaffRepository>();
                Application.Run(new Form1(staffRepository));
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddDbContext<StaffContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FrisbyTestAppDb;Trusted_Connection=True;"));
        }
    }

}