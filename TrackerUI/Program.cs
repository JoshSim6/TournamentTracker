namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            //Initialize the database connection(s)
            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.TextFile);
            Application.Run(new CreatePrizeForm());

            //Application.Run(new TournamentDashboardForm());

        }
    }
}