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
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocetnaStranicadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajKandidataButton
            // 
            this.DodajKandidataButton.Location = new System.Drawing.Point(1621, 651);
            this.DodajKandidataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DodajKandidataButton.Name = "DodajKandidataButton";
            this.DodajKandidataButton.Size = new System.Drawing.Size(195, 44);
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
            this.PocetnaStranicadataGridView.Location = new System.Drawing.Point(68, 57);
            this.PocetnaStranicadataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PocetnaStranicadataGridView.Name = "PocetnaStranicadataGridView";
            this.PocetnaStranicadataGridView.RowHeadersWidth = 51;
            this.PocetnaStranicadataGridView.Size = new System.Drawing.Size(1725, 226);
            this.PocetnaStranicadataGridView.TabIndex = 1;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 750);
            this.Controls.Add(this.PocetnaStranicadataGridView);
            this.Controls.Add(this.DodajKandidataButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PocetnaForma";
            this.Text = "Pocetna Stranica";
            this.Load += new System.EventHandler(this.PocetnaForma_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocetnaStranicadataGridView)).EndInit();
            this.ResumeLayout(false);

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
    }
}

