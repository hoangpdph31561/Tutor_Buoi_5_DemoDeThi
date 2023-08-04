using TuTor_Ngay4_8_23_CS3.View;

namespace TuTor_Ngay4_8_23_CS3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            //Scaffold-DbContext 'Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=TUTOR_CS3_CHUCVU;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QuanLyNhanVien());
        }
    }
}