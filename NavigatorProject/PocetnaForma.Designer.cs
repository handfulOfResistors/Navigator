namespace NavigatorProject
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.DodajKandidataButton = new System.Windows.Forms.Button();
            this.kandidatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PocetnaStranicadataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DugmeZaPretragubutton = new System.Windows.Forms.Button();
            this.TekstZaPretragutextBox = new System.Windows.Forms.TextBox();
            this.IzmeniKandidataButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocetnaStranicadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajKandidataButton
            // 
            this.DodajKandidataButton.Location = new System.Drawing.Point(279, 588);
            this.DodajKandidataButton.Name = "DodajKandidataButton";
            this.DodajKandidataButton.Size = new System.Drawing.Size(185, 79);
            this.DodajKandidataButton.TabIndex = 0;
            this.DodajKandidataButton.Text = "Dodaj Kandidata";
            this.DodajKandidataButton.UseVisualStyleBackColor = true;
            this.DodajKandidataButton.Click += new System.EventHandler(this.DodajKandidata_Click);
            // 
            // kandidatsBindingSource
            // 
            this.kandidatsBindingSource.DataMember = "Kandidats";
            // 
            // PocetnaStranicadataGridView
            // 
            this.PocetnaStranicadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PocetnaStranicadataGridView.Location = new System.Drawing.Point(51, 46);
            this.PocetnaStranicadataGridView.Name = "PocetnaStranicadataGridView";
            this.PocetnaStranicadataGridView.RowHeadersWidth = 51;
            this.PocetnaStranicadataGridView.Size = new System.Drawing.Size(1250, 396);
            this.PocetnaStranicadataGridView.TabIndex = 1;
            this.PocetnaStranicadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PocetnaStranicadataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista svih kandidata";
            // 
            // DugmeZaPretragubutton
            // 
            this.DugmeZaPretragubutton.Location = new System.Drawing.Point(1226, 16);
            this.DugmeZaPretragubutton.Name = "DugmeZaPretragubutton";
            this.DugmeZaPretragubutton.Size = new System.Drawing.Size(75, 23);
            this.DugmeZaPretragubutton.TabIndex = 3;
            this.DugmeZaPretragubutton.Text = "Pretraži";
            this.DugmeZaPretragubutton.UseVisualStyleBackColor = true;
            this.DugmeZaPretragubutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TekstZaPretragutextBox
            // 
            this.TekstZaPretragutextBox.Location = new System.Drawing.Point(1116, 16);
            this.TekstZaPretragutextBox.Name = "TekstZaPretragutextBox";
            this.TekstZaPretragutextBox.Size = new System.Drawing.Size(100, 20);
            this.TekstZaPretragutextBox.TabIndex = 4;
            // 
            // IzmeniKandidataButton
            // 
            this.IzmeniKandidataButton.Location = new System.Drawing.Point(506, 588);
            this.IzmeniKandidataButton.Name = "IzmeniKandidataButton";
            this.IzmeniKandidataButton.Size = new System.Drawing.Size(177, 79);
            this.IzmeniKandidataButton.TabIndex = 5;
            this.IzmeniKandidataButton.Text = "Izmeni Kandidata";
            this.IzmeniKandidataButton.UseVisualStyleBackColor = true;
            this.IzmeniKandidataButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 219);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(742, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 77);
            this.button3.TabIndex = 7;
            this.button3.Text = "Obrisi Kandidata";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1198, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Preuzmi XLSX";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 691);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IzmeniKandidataButton);
            this.Controls.Add(this.TekstZaPretragutextBox);
            this.Controls.Add(this.DugmeZaPretragubutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PocetnaStranicadataGridView);
            this.Controls.Add(this.DodajKandidataButton);
            this.Name = "PocetnaForma";
            this.Text = "Kandidati za posao";
            this.Load += new System.EventHandler(this.PocetnaForma_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocetnaStranicadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajKandidataButton;
        private System.Windows.Forms.Button button2;
        
        private System.Windows.Forms.BindingSource kandidatsBindingSource;
        
        private System.Windows.Forms.DataGridView PocetnaStranicadataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jMBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn prilogCVDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DugmeZaPretragubutton;
        private System.Windows.Forms.TextBox TekstZaPretragutextBox;
        private System.Windows.Forms.Button IzmeniKandidataButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

