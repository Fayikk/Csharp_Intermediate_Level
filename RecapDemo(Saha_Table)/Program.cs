namespace RecapDemo_Saha_Table_
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
            Button button = new Button();//BUTON nesnesi oluþturmuþ olduk.
            button.Width = 50;
            button.Height = 50;

        }
    }
}