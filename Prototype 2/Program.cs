namespace Prototype_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        /// -----------COLOR PALLETE ------------ ///
        ///
        ///Color Hex ARGB
        ///White #E4E6F3 (1, 228, 230, 243)
        ///Yellow #F4F880 (1, 224, 248, 128)
        ///Light Orange #F2A60A (1, 242, 166, 10)
        ///Dark Orange #D7620F (1, 215, 98, 15)
        ///Dark Red #961B06 (1, 150, 27, 6)


        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }
}