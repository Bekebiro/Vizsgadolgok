namespace uzenetKodolo
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
            this.kuldoNevTxtBox = new System.Windows.Forms.TextBox();
            this.kuldoIpTxtBox = new System.Windows.Forms.TextBox();
            this.vevoNevTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uzenetTxtBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vevoIpTxtBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.kuldesBtn = new System.Windows.Forms.Button();
            this.kodolasBtn = new System.Windows.Forms.Button();
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.dekodoloBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kuldoNevTxtBox
            // 
            this.kuldoNevTxtBox.Location = new System.Drawing.Point(100, 18);
            this.kuldoNevTxtBox.Name = "kuldoNevTxtBox";
            this.kuldoNevTxtBox.Size = new System.Drawing.Size(167, 20);
            this.kuldoNevTxtBox.TabIndex = 0;
            // 
            // kuldoIpTxtBox
            // 
            this.kuldoIpTxtBox.Location = new System.Drawing.Point(100, 58);
            this.kuldoIpTxtBox.Name = "kuldoIpTxtBox";
            this.kuldoIpTxtBox.Size = new System.Drawing.Size(167, 20);
            this.kuldoIpTxtBox.TabIndex = 1;
            // 
            // vevoNevTxtBox
            // 
            this.vevoNevTxtBox.Location = new System.Drawing.Point(100, 104);
            this.vevoNevTxtBox.Name = "vevoNevTxtBox";
            this.vevoNevTxtBox.Size = new System.Drawing.Size(167, 20);
            this.vevoNevTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Küldő (IP):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vevő (név):";
            // 
            // uzenetTxtBox
            // 
            this.uzenetTxtBox.Location = new System.Drawing.Point(292, 81);
            this.uzenetTxtBox.Name = "uzenetTxtBox";
            this.uzenetTxtBox.Size = new System.Drawing.Size(179, 82);
            this.uzenetTxtBox.TabIndex = 6;
            this.uzenetTxtBox.Text = "";
            this.uzenetTxtBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Küldő (név):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vevő (IP):";
            // 
            // vevoIpTxtBox
            // 
            this.vevoIpTxtBox.Location = new System.Drawing.Point(100, 143);
            this.vevoIpTxtBox.Name = "vevoIpTxtBox";
            this.vevoIpTxtBox.Size = new System.Drawing.Size(167, 20);
            this.vevoIpTxtBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Üzenet:";
            // 
            // kuldesBtn
            // 
            this.kuldesBtn.Location = new System.Drawing.Point(503, 12);
            this.kuldesBtn.Name = "kuldesBtn";
            this.kuldesBtn.Size = new System.Drawing.Size(109, 66);
            this.kuldesBtn.TabIndex = 12;
            this.kuldesBtn.Text = "Küldés";
            this.kuldesBtn.UseVisualStyleBackColor = true;
            this.kuldesBtn.Click += new System.EventHandler(this.kuldesBtn_Click);
            // 
            // kodolasBtn
            // 
            this.kodolasBtn.Location = new System.Drawing.Point(503, 104);
            this.kodolasBtn.Name = "kodolasBtn";
            this.kodolasBtn.Size = new System.Drawing.Size(109, 66);
            this.kodolasBtn.TabIndex = 13;
            this.kodolasBtn.Text = "Kódolás";
            this.kodolasBtn.UseVisualStyleBackColor = true;
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.BackColor = System.Drawing.Color.Red;
            this.kilepesBtn.ForeColor = System.Drawing.Color.White;
            this.kilepesBtn.Location = new System.Drawing.Point(650, 12);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(109, 66);
            this.kilepesBtn.TabIndex = 14;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = false;
            this.kilepesBtn.Click += new System.EventHandler(this.kilepesBtn_Click);
            // 
            // dekodoloBtn
            // 
            this.dekodoloBtn.Location = new System.Drawing.Point(650, 104);
            this.dekodoloBtn.Name = "dekodoloBtn";
            this.dekodoloBtn.Size = new System.Drawing.Size(109, 66);
            this.dekodoloBtn.TabIndex = 15;
            this.dekodoloBtn.Text = "Dekódolás";
            this.dekodoloBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dekodoloBtn);
            this.Controls.Add(this.kilepesBtn);
            this.Controls.Add(this.kodolasBtn);
            this.Controls.Add(this.kuldesBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.vevoIpTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uzenetTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vevoNevTxtBox);
            this.Controls.Add(this.kuldoIpTxtBox);
            this.Controls.Add(this.kuldoNevTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kuldoNevTxtBox;
        private System.Windows.Forms.TextBox kuldoIpTxtBox;
        private System.Windows.Forms.TextBox vevoNevTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox uzenetTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vevoIpTxtBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kuldesBtn;
        private System.Windows.Forms.Button kodolasBtn;
        private System.Windows.Forms.Button kilepesBtn;
        private System.Windows.Forms.Button dekodoloBtn;
        private System.Windows.Forms.Label label6;
    }
}

