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
            this.DodajKandidataButton = new System.Windows.Forms.Button();
            this.kandidatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PocetnaStranicadataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DugmeZaPretragubutton = new System.Windows.Forms.Button();
            this.TekstZaPretragutextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocetnaStranicadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajKandidataButton
            // 
            this.DodajKandidataButton.Location = new System.Drawing.Point(1216, 529);
            this.DodajKandidataButton.Name = "DodajKandidataButton";
            this.DodajKandidataButton.Size = new System.Drawing.Size(146, 36);
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
            this.PocetnaStranicadataGridView.Size = new System.Drawing.Size(1311, 396);
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
            this.DugmeZaPretragubutton.Location = new System.Drawing.Point(1286, 16);
            this.DugmeZaPretragubutton.Name = "DugmeZaPretragubutton";
            this.DugmeZaPretragubutton.Size = new System.Drawing.Size(75, 23);
            this.DugmeZaPretragubutton.TabIndex = 3;
            this.DugmeZaPretragubutton.Text = "Pretraži";
            this.DugmeZaPretragubutton.UseVisualStyleBackColor = true;
            this.DugmeZaPretragubutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TekstZaPretragutextBox
            // 
            this.TekstZaPretragutextBox.Location = new System.Drawing.Point(1176, 16);
            this.TekstZaPretragutextBox.Name = "TekstZaPretragutextBox";
            this.TekstZaPretragutextBox.Size = new System.Drawing.Size(100, 20);
            this.TekstZaPretragutextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1021, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Izmeni Kandidata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 611);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

