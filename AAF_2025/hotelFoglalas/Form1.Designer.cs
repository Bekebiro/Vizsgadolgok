namespace hotelFoglalas
{
    partial class Form1
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
            this.comboBoxEv = new System.Windows.Forms.ComboBox();
            this.comboBoxHonap = new System.Windows.Forms.ComboBox();
            this.btnTelefon = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnFogalas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEv
            // 
            this.comboBoxEv.FormattingEnabled = true;
            this.comboBoxEv.Location = new System.Drawing.Point(12, 12);
            this.comboBoxEv.Name = "comboBoxEv";
            this.comboBoxEv.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEv.TabIndex = 0;
            this.comboBoxEv.SelectedIndexChanged += new System.EventHandler(this.comboBoxEv_SelectedIndexChanged);
            // 
            // comboBoxHonap
            // 
            this.comboBoxHonap.FormattingEnabled = true;
            this.comboBoxHonap.Location = new System.Drawing.Point(160, 12);
            this.comboBoxHonap.Name = "comboBoxHonap";
            this.comboBoxHonap.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHonap.TabIndex = 1;
            this.comboBoxHonap.SelectedIndexChanged += new System.EventHandler(this.comboBoxHonap_SelectedIndexChanged);
            // 
            // btnTelefon
            // 
            this.btnTelefon.Location = new System.Drawing.Point(819, 12);
            this.btnTelefon.Name = "btnTelefon";
            this.btnTelefon.Size = new System.Drawing.Size(153, 55);
            this.btnTelefon.TabIndex = 2;
            this.btnTelefon.Text = "Telefon";
            this.btnTelefon.UseVisualStyleBackColor = true;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(819, 89);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(153, 55);
            this.btnStat.TabIndex = 3;
            this.btnStat.Text = "Statisztika";
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // btnFogalas
            // 
            this.btnFogalas.Location = new System.Drawing.Point(819, 165);
            this.btnFogalas.Name = "btnFogalas";
            this.btnFogalas.Size = new System.Drawing.Size(153, 55);
            this.btnFogalas.TabIndex = 4;
            this.btnFogalas.Text = "Foglalás";
            this.btnFogalas.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(819, 243);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(153, 55);
            this.btnKilepes.TabIndex = 5;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnFogalas);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnTelefon);
            this.Controls.Add(this.comboBoxHonap);
            this.Controls.Add(this.comboBoxEv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEv;
        private System.Windows.Forms.ComboBox comboBoxHonap;
        private System.Windows.Forms.Button btnTelefon;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnFogalas;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Label label1;
    }
}

