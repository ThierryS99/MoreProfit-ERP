namespace _Profit___ERP_Open_Source
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}