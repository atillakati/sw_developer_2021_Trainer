namespace Wifi.PlaylistEditor.UI
{
    partial class frmNewPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btt_cancel = new System.Windows.Forms.Button();
            this.btt_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_titel = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btt_cancel
            // 
            this.btt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btt_cancel.Location = new System.Drawing.Point(204, 147);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(75, 23);
            this.btt_cancel.TabIndex = 3;
            this.btt_cancel.Text = "Abbruch";
            this.btt_cancel.UseVisualStyleBackColor = true;
            this.btt_cancel.Click += new System.EventHandler(this.btt_cancel_Click);
            // 
            // btt_ok
            // 
            this.btt_ok.Location = new System.Drawing.Point(292, 147);
            this.btt_ok.Name = "btt_ok";
            this.btt_ok.Size = new System.Drawing.Size(75, 23);
            this.btt_ok.TabIndex = 2;
            this.btt_ok.Text = "OK";
            this.btt_ok.UseVisualStyleBackColor = true;
            this.btt_ok.Click += new System.EventHandler(this.btt_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor:";
            // 
            // txt_titel
            // 
            this.txt_titel.Location = new System.Drawing.Point(100, 52);
            this.txt_titel.Name = "txt_titel";
            this.txt_titel.Size = new System.Drawing.Size(267, 20);
            this.txt_titel.TabIndex = 0;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(100, 96);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(267, 20);
            this.txt_autor.TabIndex = 1;
            // 
            // frmNewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btt_cancel;
            this.ClientSize = new System.Drawing.Size(415, 198);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_titel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_ok);
            this.Controls.Add(this.btt_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neue Playlist erzeugen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_cancel;
        private System.Windows.Forms.Button btt_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_titel;
        private System.Windows.Forms.TextBox txt_autor;
    }
}