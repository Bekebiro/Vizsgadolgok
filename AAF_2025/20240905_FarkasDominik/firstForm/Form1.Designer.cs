namespace firstForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plusz = new System.Windows.Forms.RadioButton();
            this.minusz = new System.Windows.Forms.RadioButton();
            this.szorzas = new System.Windows.Forms.RadioButton();
            this.osztas = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Location = new System.Drawing.Point(292, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 62);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(703, 384);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(703, 407);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 4;
            // 
            // plusz
            // 
            this.plusz.AutoSize = true;
            this.plusz.Location = new System.Drawing.Point(240, 60);
            this.plusz.Name = "plusz";
            this.plusz.Size = new System.Drawing.Size(31, 17);
            this.plusz.TabIndex = 5;
            this.plusz.TabStop = true;
            this.plusz.Text = "+";
            this.plusz.UseVisualStyleBackColor = true;
            this.plusz.CheckedChanged += new System.EventHandler(this.plusz_CheckedChanged);
            // 
            // minusz
            // 
            this.minusz.AutoSize = true;
            this.minusz.Location = new System.Drawing.Point(240, 83);
            this.minusz.Name = "minusz";
            this.minusz.Size = new System.Drawing.Size(28, 17);
            this.minusz.TabIndex = 6;
            this.minusz.TabStop = true;
            this.minusz.Text = "-";
            this.minusz.UseVisualStyleBackColor = true;
            this.minusz.CheckedChanged += new System.EventHandler(this.minusz_CheckedChanged);
            // 
            // szorzas
            // 
            this.szorzas.AutoSize = true;
            this.szorzas.Location = new System.Drawing.Point(240, 106);
            this.szorzas.Name = "szorzas";
            this.szorzas.Size = new System.Drawing.Size(29, 17);
            this.szorzas.TabIndex = 7;
            this.szorzas.TabStop = true;
            this.szorzas.Text = "*";
            this.szorzas.UseVisualStyleBackColor = true;
            this.szorzas.CheckedChanged += new System.EventHandler(this.szorzas_CheckedChanged);
            // 
            // osztas
            // 
            this.osztas.AutoSize = true;
            this.osztas.Location = new System.Drawing.Point(240, 129);
            this.osztas.Name = "osztas";
            this.osztas.Size = new System.Drawing.Size(28, 17);
            this.osztas.TabIndex = 8;
            this.osztas.TabStop = true;
            this.osztas.Text = ":";
            this.osztas.UseVisualStyleBackColor = true;
            this.osztas.CheckedChanged += new System.EventHandler(this.osztas_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(577, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.osztas);
            this.Controls.Add(this.szorzas);
            this.Controls.Add(this.minusz);
            this.Controls.Add(this.plusz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "FirstForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton plusz;
        private System.Windows.Forms.RadioButton minusz;
        private System.Windows.Forms.RadioButton szorzas;
        private System.Windows.Forms.RadioButton osztas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

