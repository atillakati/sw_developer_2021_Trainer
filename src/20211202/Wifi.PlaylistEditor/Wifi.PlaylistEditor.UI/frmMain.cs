using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.UI
{
    public partial class frmMain : Form
    {
        private INewPlaylistCreator _newPlaylistCreator;
        private IPlaylist _playlist;

        public frmMain()
        {
            InitializeComponent();

            //Erzeugungsabhängigkeit!!! BÖSE!
            //_newPlaylistCreator = new DummyNewPlaylistCreator();
            _newPlaylistCreator = new frmNewPlaylist();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_newPlaylistCreator.OpenDialog() != DialogResult.OK)
            {
                return;
            }

            _playlist = new Playlist(_newPlaylistCreator.Title, 
                                     _newPlaylistCreator.Author, 
                                     _newPlaylistCreator.CreatedAt);
            UpdateView();
        }

        private void UpdateView()
        {
            lbl_autor.Text = $"Autor: {_playlist.Author} Created at: {_playlist.CreateDate}";
            lbl_title.Text = $"{_playlist.Name} [{_playlist.Duration}]"; 
            
            //ToDo: display the items here!!!
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearView();
        }

        private void ClearView()
        {
            lbl_autor.Text = string.Empty;
            lbl_title.Text = string.Empty;
            lbl_itemInfo.Text = string.Empty;
        }
    }
}
