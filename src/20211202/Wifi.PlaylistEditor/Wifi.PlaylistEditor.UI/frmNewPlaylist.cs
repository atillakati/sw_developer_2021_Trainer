using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.UI
{
    public partial class frmNewPlaylist : Form, INewPlaylistCreator
    {
        private DateTime _createdAt;

        public frmNewPlaylist()
        {
            InitializeComponent();
        }

        public string Title => txt_titel.Text;

        public string Author => txt_autor.Text;

        public DateTime CreatedAt => _createdAt;

        public DialogResult OpenDialog()
        {
            txt_titel.Text = string.Empty;
            txt_autor.Text = string.Empty;

            txt_titel.Focus();

            return this.ShowDialog();
        }

        private void btt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btt_ok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_titel.Text) || string.IsNullOrEmpty(txt_autor.Text))
            {
                return;
            }

            _createdAt = DateTime.Now;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
