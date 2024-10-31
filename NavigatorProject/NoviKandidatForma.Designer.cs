namespace NavigatorProject
{
    partial class NoviKandidatForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviKandidatForma));
            this.ImeBox = new System.Windows.Forms.TextBox();
            this.PrezimeBox = new System.Windows.Forms.TextBox();
            this.JMBGBox = new System.Windows.Forms.TextBox();
            this.DatumRodjenjaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.TelefonBox = new System.Windows.Forms.TextBox();
            this.NapomenaBox = new System.Windows.Forms.TextBox();
            this.PoslednjaIzmenaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OcenacomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
            this.CVAddedStatus = new System.Windows.Forms.Label();
            this.PictureAddedStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImeBox
            // 
            this.ImeBox.Location = new System.Drawing.Point(26, 26);
            this.ImeBox.Name = "ImeBox";
            this.ImeBox.Size = new System.Drawing.Size(100, 20);
            this.ImeBox.TabIndex = 0;
            // 
            // PrezimeBox
            // 
            this.PrezimeBox.Location = new System.Drawing.Point(26, 64);
            this.PrezimeBox.Name = "PrezimeBox";
            this.PrezimeBox.Size = new System.Drawing.Size(100, 20);
            this.PrezimeBox.TabIndex = 1;
            // 
            // JMBGBox
            // 
            this.JMBGBox.Location = new System.Drawing.Point(26, 105);
            this.JMBGBox.Name = "JMBGBox";
            this.JMBGBox.Size = new System.Drawing.Size(100, 20);
            this.JMBGBox.TabIndex = 2;
            // 
            // DatumRodjenjaTimePicker
            // 
            this.DatumRodjenjaTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DatumRodjenjaTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatumRodjenjaTimePicker.Location = new System.Drawing.Point(26, 156);
            this.DatumRodjenjaTimePicker.Name = "DatumRodjenjaTimePicker";
            this.DatumRodjenjaTimePicker.Size = new System.Drawing.Size(100, 20);
            this.DatumRodjenjaTimePicker.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(26, 205);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 4;
            // 
            // TelefonBox
            // 
            this.TelefonBox.Location = new System.Drawing.Point(26, 250);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonBox.TabIndex = 5;
            // 
            // NapomenaBox
            // 
            this.NapomenaBox.Location = new System.Drawing.Point(26, 291);
            this.NapomenaBox.Name = "NapomenaBox";
            this.NapomenaBox.Size = new System.Drawing.Size(100, 20);
            this.NapomenaBox.TabIndex = 6;
            // 
            // PoslednjaIzmenaTimePicker
            // 
            this.PoslednjaIzmenaTimePicker.Location = new System.Drawing.Point(26, 335);
            this.PoslednjaIzmenaTimePicker.Name = "PoslednjaIzmenaTimePicker";
            this.PoslednjaIzmenaTimePicker.Size = new System.Drawing.Size(100, 20);
            this.PoslednjaIzmenaTimePicker.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj CV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dodaj sliku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OcenacomboBox
            // 
            this.OcenacomboBox.FormattingEnabled = true;
            this.OcenacomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.OcenacomboBox.Location = new System.Drawing.Point(26, 458);
            this.OcenacomboBox.Name = "OcenacomboBox";
            this.OcenacomboBox.Size = new System.Drawing.Size(121, 21);
            this.OcenacomboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "JMBG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Datum rodjenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Napomena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Poslednja izmena";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ocena";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Status";
            // 
            // StatuscomboBox
            // 
            this.StatuscomboBox.FormattingEnabled = true;
            this.StatuscomboBox.Items.AddRange(new object[] {
            "Kandidat",
            "Kvalifikacija",
            "Intervju",
            "Uži krug",
            "Zaposlen"});
            this.StatuscomboBox.Location = new System.Drawing.Point(26, 502);
            this.StatuscomboBox.Name = "StatuscomboBox";
            this.StatuscomboBox.Size = new System.Drawing.Size(121, 21);
            this.StatuscomboBox.TabIndex = 21;
            // 
            // CVAddedStatus
            // 
            this.CVAddedStatus.AutoSize = true;
            this.CVAddedStatus.Location = new System.Drawing.Point(108, 385);
            this.CVAddedStatus.Name = "CVAddedStatus";
            this.CVAddedStatus.Size = new System.Drawing.Size(0, 13);
            this.CVAddedStatus.TabIndex = 22;
            // 
            // PictureAddedStatus
            // 
            this.PictureAddedStatus.AutoSize = true;
            this.PictureAddedStatus.Location = new System.Drawing.Point(108, 424);
            this.PictureAddedStatus.Name = "PictureAddedStatus";
            this.PictureAddedStatus.Size = new System.Drawing.Size(0, 13);
            this.PictureAddedStatus.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 67);
            this.button3.TabIndex = 24;
            this.button3.Text = "Dodaj kandidata";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DodajKandidata_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 191);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // NoviKandidatForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PictureAddedStatus);
            this.Controls.Add(this.CVAddedStatus);
            this.Controls.Add(this.StatuscomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OcenacomboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PoslednjaIzmenaTimePicker);
            this.Controls.Add(this.NapomenaBox);
            this.Controls.Add(this.TelefonBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.DatumRodjenjaTimePicker);
            this.Controls.Add(this.JMBGBox);
            this.Controls.Add(this.PrezimeBox);
            this.Controls.Add(this.ImeBox);
            this.Name = "NoviKandidatForma";
            this.Text = "NoviKandidatForma";
            this.Load += new System.EventHandler(this.NoviKandidatForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeBox;
        private System.Windows.Forms.TextBox PrezimeBox;
        private System.Windows.Forms.TextBox JMBGBox;
        private System.Windows.Forms.DateTimePicker DatumRodjenjaTimePicker;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox TelefonBox;
        private System.Windows.Forms.TextBox NapomenaBox;
        private System.Windows.Forms.DateTimePicker PoslednjaIzmenaTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox OcenacomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox StatuscomboBox;
        private System.Windows.Forms.Label CVAddedStatus;
        private System.Windows.Forms.Label PictureAddedStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}