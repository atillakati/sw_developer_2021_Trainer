using System;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.UI
{
    public interface INewPlaylistCreator
    {
        string Title { get; }
        string Author { get; }
        DateTime CreatedAt { get; }

        DialogResult OpenDialog();
    }
}
