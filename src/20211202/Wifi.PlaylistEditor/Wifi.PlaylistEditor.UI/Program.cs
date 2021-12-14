using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Factories;

namespace Wifi.PlaylistEditor.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var itemFactory = new PlaylistItemFactory();
            var repositoryFactory = new RepositoryFactory(itemFactory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(itemFactory, repositoryFactory));
        }
    }
}
