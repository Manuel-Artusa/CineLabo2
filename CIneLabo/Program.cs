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
            Application.Run(new frmIniciarSesion());
=======

            Application.Run(new FrmActualizacionPrecio());
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e

        }
    }
}