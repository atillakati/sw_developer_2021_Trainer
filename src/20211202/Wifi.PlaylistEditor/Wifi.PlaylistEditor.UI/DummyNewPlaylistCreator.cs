using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.UI
{
    internal class DummyNewPlaylistCreator : INewPlaylistCreator
    {
        public string Title => "Dummy Playlist";

        public string Author => "Wifi";

        public DateTime CreatedAt => DateTime.Now;

        public DialogResult OpenDialog()
        {
            return DialogResult.OK;
        }
    }
}
