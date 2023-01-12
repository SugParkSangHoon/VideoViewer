namespace Login_forme
{
    partial class frmTemaOptions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTekst = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelNapisano = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNaslovIzmijeni = new System.Windows.Forms.TextBox();
            this.btnKomentar = new System.Windows.Forms.Button();
            this.dgvKomentar = new System.Windows.Forms.DataGridView();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTekst
            // 
            this.txtTekst.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTekst.Location = new System.Drawing.Point(12, 82);
            this.txtTekst.MaximumSize = new System.Drawing.Size(391, 141);
            this.txtTekst.MinimumSize = new System.Drawing.Size(391, 100);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.ReadOnly = true;
            this.txtTekst.Size = new System.Drawing.Size(391, 141);
            this.txtTekst.TabIndex = 2;
            this.txtTekst.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(12, 57);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(55, 13);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "Napisano:";
            // 
            // labelNapisano
            // 
            this.labelNapisano.AutoSize = true;
            this.labelNapisano.Location = new System.Drawing.Point(87, 57);
            this.labelNapisano.Name = "labelNapisano";
            this.labelNapisano.Size = new System.Drawing.Size(35, 13);
            this.labelNapisano.TabIndex = 5;
            this.labelNapisano.Text = "label3";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(342, 47);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(51, 22);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "label3";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(86, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(60, 28);
            this.lblNaslov.TabIndex = 7;
            this.lblNaslov.Text = "label3";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(15, 229);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Uredi";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Spasi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNaslovIzmijeni
            // 
            this.txtNaslovIzmijeni.Location = new System.Drawing.Point(40, 22);
            this.txtNaslovIzmijeni.Name = "txtNaslovIzmijeni";
            this.txtNaslovIzmijeni.Size = new System.Drawing.Size(241, 20);
            this.txtNaslovIzmijeni.TabIndex = 10;
            // 
            // btnKomentar
            // 
            this.btnKomentar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomentar.Location = new System.Drawing.Point(149, 254);
            this.btnKomentar.Name = "btnKomentar";
            this.btnKomentar.Size = new System.Drawing.Size(105, 34);
            this.btnKomentar.TabIndex = 12;
            this.btnKomentar.Text = "Komentarisi";
            this.btnKomentar.UseVisualStyleBackColor = true;
            this.btnKomentar.Click += new System.EventHandler(this.btnKomentar_Click);
            // 
            // dgvKomentar
            // 
            this.dgvKomentar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomentar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKomentar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKomentar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvKomentar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKomentar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Komentar,
            this.Napisao,
            this.ID});
            this.dgvKomentar.Location = new System.Drawing.Point(15, 294);
            this.dgvKomentar.Name = "dgvKomentar";
            this.dgvKomentar.ReadOnly = true;
            this.dgvKomentar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKomentar.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKomentar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvKomentar.RowTemplate.Height = 24;
            this.dgvKomentar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKomentar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomentar.Size = new System.Drawing.Size(388, 153);
            this.dgvKomentar.TabIndex = 13;
            this.dgvKomentar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomentar_CellContentClick);
            // 
            // Komentar
            // 
            this.Komentar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Komentar.DataPropertyName = "Komentar";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Komentar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            // 
            // Napisao
            // 
            this.Napisao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napisao.DataPropertyName = "Napisao";
            this.Napisao.FillWeight = 30F;
            this.Napisao.HeaderText = "Napisao";
            this.Napisao.Name = "Napisao";
            this.Napisao.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "KomentarId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUredi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUredi.Location = new System.Drawing.Point(318, 453);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 14;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTopic.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteTopic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTopic.Location = new System.Drawing.Point(175, 225);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(60, 23);
            this.btnDeleteTopic.TabIndex = 16;
            this.btnDeleteTopic.Text = "Obrisi";
            this.btnDeleteTopic.UseVisualStyleBackColor = false;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // frmTemaOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(433, 488);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dgvKomentar);
            this.Controls.Add(this.btnKomentar);
            this.Controls.Add(this.txtNaslovIzmijeni);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.labelNapisano);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTekst);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmTemaOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tema1";
            this.Load += new System.EventHandler(this.frmTemaOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelNapisano;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNaslovIzmijeni;
        private System.Windows.Forms.Button btnKomentar;
        private System.Windows.Forms.DataGridView dgvKomentar;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napisao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnDeleteTopic;
    }
}