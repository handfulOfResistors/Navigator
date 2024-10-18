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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.kandidatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1294, 184);
            this.dataGridView1.TabIndex = 1;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DodajKandidataButton);
            this.Name = "PocetnaForma";
            this.Text = "Pocetna Stranica";
            this.Load += new System.EventHandler(this.PocetnaForma_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kandidatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DodajKandidataButton;
        private System.Windows.Forms.Button button2;
        
        private System.Windows.Forms.BindingSource kandidatsBindingSource;
        
        private System.Windows.Forms.DataGridView dataGridView1;
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

