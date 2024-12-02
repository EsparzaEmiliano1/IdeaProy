namespace WinFormsAppIdeaProy
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
            Application.Run(new Form3());

            //// parte de administrador comentado para revisar el form3/formPortada
            //Application.Run(new Form1());
        }
    }
}