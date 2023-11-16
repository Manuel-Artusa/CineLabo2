using CineApp.Forms;
using CIneLabo.Presentacion;
using CinesFront.Presentacion;

namespace CIneLabo
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
<<<<<<< HEAD
            //Application.Run(new FrmInformeMejoresFormasDePago());
            Application.Run(new FrmActualizacionPrecio());

            //Application.Run(new FrmActualizacionPrecio());
=======
            Application.Run(new FrmButacasDisponibles());
>>>>>>> 1ee5d1b821a68283741f8d20aae8557bae997875

        }
    }
}