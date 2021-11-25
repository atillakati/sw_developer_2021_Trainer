namespace BuchVerwaltung.UI
{
    partial class MainForm
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
            this.btt_clear = new System.Windows.Forms.Button();
            this.btt_speichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Titel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_AllesLaden = new System.Windows.Forms.Button();
            this.btt_quit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Verlag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btt_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btt_clear
            // 
            this.btt_clear.Location = new System.Drawing.Point(369, 195);
            this.btt_clear.Name = "btt_clear";
            this.btt_clear.Size = new System.Drawing.Size(100, 40);
            this.btt_clear.TabIndex = 0;
            this.btt_clear.Text = "Leeren";
            this.btt_clear.UseVisualStyleBackColor = true;
            this.btt_clear.Click += new System.EventHandler(this.ClearFormContents);
            // 
            // btt_speichern
            // 
            this.btt_speichern.Location = new System.Drawing.Point(137, 496);
            this.btt_speichern.Name = "btt_speichern";
            this.btt_speichern.Size = new System.Drawing.Size(100, 40);
            this.btt_speichern.TabIndex = 1;
            this.btt_speichern.Text = "Speichern";
            this.btt_speichern.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titel";
            // 
            // txt_Titel
            // 
            this.txt_Titel.Location = new System.Drawing.Point(125, 18);
            this.txt_Titel.Name = "txt_Titel";
            this.txt_Titel.Size = new System.Drawing.Size(313, 20);
            this.txt_Titel.TabIndex = 3;
            this.txt_Titel.Text = "Hier!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buchverwaltung";
            // 
            // btt_AllesLaden
            // 
            this.btt_AllesLaden.Location = new System.Drawing.Point(18, 496);
            this.btt_AllesLaden.Name = "btt_AllesLaden";
            this.btt_AllesLaden.Size = new System.Drawing.Size(100, 40);
            this.btt_AllesLaden.TabIndex = 5;
            this.btt_AllesLaden.Text = "Alles laden";
            this.btt_AllesLaden.UseVisualStyleBackColor = true;
            // 
            // btt_quit
            // 
            this.btt_quit.Location = new System.Drawing.Point(366, 496);
            this.btt_quit.Name = "btt_quit";
            this.btt_quit.Size = new System.Drawing.Size(100, 40);
            this.btt_quit.TabIndex = 6;
            this.btt_quit.Text = "Verlassen";
            this.btt_quit.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 255);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(454, 222);
            this.textBox2.TabIndex = 7;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(125, 44);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(313, 20);
            this.txt_Autor.TabIndex = 9;
            this.txt_Autor.Text = "Hier!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autor";
            // 
            // txt_Verlag
            // 
            this.txt_Verlag.Location = new System.Drawing.Point(125, 70);
            this.txt_Verlag.Name = "txt_Verlag";
            this.txt_Verlag.Size = new System.Drawing.Size(313, 20);
            this.txt_Verlag.TabIndex = 11;
            this.txt_Verlag.Text = "Hier!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Verlag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Erscheinungsjahr";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Titel);
            this.groupBox1.Controls.Add(this.txt_Verlag);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Autor);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neue Buchdaten";
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(254, 195);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(100, 40);
            this.btt_add.TabIndex = 15;
            this.btt_add.Text = "Übernehmen";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(486, 548);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btt_quit);
            this.Controls.Add(this.btt_AllesLaden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btt_speichern);
            this.Controls.Add(this.btt_clear);
            this.Name = "MainForm";
            this.Text = "NetPro BookManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Windows.Forms.Button btt_clear;
        private System.Windows.Forms.Button btt_speichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_AllesLaden;
        private System.Windows.Forms.Button btt_quit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Verlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_add;
    }
}
