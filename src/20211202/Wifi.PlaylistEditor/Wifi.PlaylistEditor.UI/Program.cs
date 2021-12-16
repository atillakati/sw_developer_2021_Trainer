using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Types;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new UnityContainer();

            container.RegisterType<IRepositoryFactory, RepositoryFactory>();
            container.RegisterType<IPlaylistItemFactory, PlaylistItemFactory>();
            container.RegisterType<INewPlaylistCreator, frmNewPlaylist>();

            var mainForm = container.Resolve<frmMain>();
            
            Application.Run(mainForm);
        }
    }
}
