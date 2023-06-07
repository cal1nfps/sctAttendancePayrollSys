using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace SCTAttendanceSystemUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomePage());
        }
        public static void ConfigureServices(IServiceCollection services)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // more code here
            var path = "c:\\temp\\observations.txt";

            var estEncoding = Encoding.GetEncoding(1252);
            var est = File.ReadAllText(path, estEncoding);
            var utf = Encoding.UTF8;
            est = utf.GetString(Encoding.Convert(estEncoding, utf, estEncoding.GetBytes(est)));
        }
    }
}