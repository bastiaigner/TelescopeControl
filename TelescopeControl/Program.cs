using System;
using System.Threading;
using System.Windows.Forms;
using TelescopeControl.Alpaca;

namespace TelescopeControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var AlpacaServer = new AlpacaServer([
                new AscomFocuserApiHandler(0, TelescopeFocusers.cassegrainFocuser),
                new AscomFocuserApiHandler(1, TelescopeFocusers.primaryFocuser)
            ]);

            var tokenSource = new CancellationTokenSource();

            AlpacaServer.Start(tokenSource.Token);
            Application.Run(new MainForm());
            tokenSource.Cancel();
            tokenSource.Dispose();
        }
    }
}