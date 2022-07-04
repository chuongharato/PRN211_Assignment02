using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;


namespace SalesWinApp
{
    static class Program
    {
        
        public static IConfiguration Configuration;
        [STAThread]
        static void Main()
        {
          var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
          Configuration = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

         //   ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}