namespace Login_forme
{
    partial class Teme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgTema = new System.Windows.Forms.DataGridView();
            this.btnTema = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napravljena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTema)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTema
            // 
            this.dtgTema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naslov,
            this.Autor,
            this.Napravljena,
            this.Komentari});
            this.dtgTema.Location = new System.Drawing.Point(12, 41);
            this.dtgTema.Name = "dtgTema";
            this.dtgTema.Size = new System.Drawing.Size(536, 208);
            this.dtgTema.TabIndex = 0;
            this.dtgTema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTema_CellClick);
            this.dtgTema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTema_CellContentClick);
            this.dtgTema.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTema_CellDoubleClick);
            // 
            // btnTema
            // 
            this.btnTema.Location = new System.Drawing.Point(417, 12);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(131, 23);
            this.btnTema.TabIndex = 4;
            this.btnTema.Text = "Dodaj Novu";
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(293, 20);
            this.txtPretraga.TabIndex = 3;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(330, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Naslov
            // 
            this.Naslov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.DataPropertyName = "Autor";
            this.Autor.FillWeight = 50F;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Napravljena
            // 
            this.Napravljena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napravljena.DataPropertyName = "Napravljena";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.Napravljena.DefaultCellStyle = dataGridViewCellStyle1;
            this.Napravljena.FillWeight = 80F;
            this.Napravljena.HeaderText = "Dodana";
            this.Napravljena.Name = "Napravljena";
            this.Napravljena.ReadOnly = true;
            // 
            // Komentari
            // 
            this.Komentari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Komentari.DataPropertyName = "BrojKomentara";
            this.Komentari.FillWeight = 50F;
            this.Komentari.HeaderText = "Komentari";
            this.Komentari.Name = "Komentari";
            this.Komentari.ReadOnly = true;
            // 
            // Teme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 314);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTema);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dtgTema);
            this.Name = "Teme";
            this.Text = "Tema";
            this.Load += new System.EventHandler(this.Tema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTema;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napravljena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentari;
    }
}