using System;
using System.Configuration;
using System.Windows.Forms;
using BookStore.Repository;
using BookStore.View;

namespace BookStore
{
    internal static class Program
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

            var connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            GlobalRepository repository = new GlobalRepository(connectionString);
            var view = new BookStoreForm(repository);

            Application.Run(view);
        }
    }
}
