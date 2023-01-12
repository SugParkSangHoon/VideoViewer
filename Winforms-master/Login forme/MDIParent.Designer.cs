namespace Login_forme
{
    partial class MDIParent
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sveTemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 366);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(607, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registracijaToolStripMenuItem,
            this.korisniciToolStripMenuItem1});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registracijaToolStripMenuItem
            // 
            this.registracijaToolStripMenuItem.Name = "registracijaToolStripMenuItem";
            this.registracijaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.registracijaToolStripMenuItem.Text = "Registracija";
            this.registracijaToolStripMenuItem.Click += new System.EventHandler(this.registracijaToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem1
            // 
            this.korisniciToolStripMenuItem1.Name = "korisniciToolStripMenuItem1";
            this.korisniciToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.korisniciToolStripMenuItem1.Text = "Korisnici";
            this.korisniciToolStripMenuItem1.Click += new System.EventHandler(this.korisniciToolStripMenuItem1_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sveTemeToolStripMenuItem,
            this.dodajNovuToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            this.temaToolStripMenuItem.Click += new System.EventHandler(this.temaToolStripMenuItem_Click);
            // 
            // sveTemeToolStripMenuItem
            // 
            this.sveTemeToolStripMenuItem.Name = "sveTemeToolStripMenuItem";
            this.sveTemeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sveTemeToolStripMenuItem.Text = "Sve Teme";
            this.sveTemeToolStripMenuItem.Click += new System.EventHandler(this.sveTemeToolStripMenuItem_Click);
            // 
            // dodajNovuToolStripMenuItem
            // 
            this.dodajNovuToolStripMenuItem.Name = "dodajNovuToolStripMenuItem";
            this.dodajNovuToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.dodajNovuToolStripMenuItem.Text = "Dodaj Novu";
            this.dodajNovuToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjaviSeToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.temaToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(607, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(607, 388);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MDIParent_Scroll);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sveTemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}



