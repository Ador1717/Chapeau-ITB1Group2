<<<<<<<< Updated upstream:Chapeau/Program.cs
========
using ChepueUI;

<<<<<<< Updated upstream:Chapeau/Program.cs
>>>>>>>> Stashed changes:ChepueProject/Program.cs
=======
>>>>>>> Stashed changes:ChepueProject/Program.cs
namespace Chapeau
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
            Application.Run(new Form1());
        }
    }
}