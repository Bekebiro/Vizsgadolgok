namespace FarkasDominikDolgozat_20241017
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
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.szamolBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(252, 117);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 20);
            this.txtbox1.TabIndex = 0;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(252, 143);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 20);
            this.txtbox2.TabIndex = 1;
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Location = new System.Drawing.Point(411, 121);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(53, 17);
            this.radioBtn1.TabIndex = 2;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "LKKO";
            this.radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Location = new System.Drawing.Point(411, 144);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(53, 17);
            this.radioBtn2.TabIndex = 3;
            this.radioBtn2.TabStop = true;
            this.radioBtn2.Text = "LNKT";
            this.radioBtn2.UseVisualStyleBackColor = true;
            // 
            // szamolBtn
            // 
            this.szamolBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.szamolBtn.ForeColor = System.Drawing.Color.White;
            this.szamolBtn.Location = new System.Drawing.Point(205, 310);
            this.szamolBtn.Name = "szamolBtn";
            this.szamolBtn.Size = new System.Drawing.Size(147, 50);
            this.szamolBtn.TabIndex = 4;
            this.szamolBtn.Text = "Számol";
            this.szamolBtn.UseVisualStyleBackColor = false;
            this.szamolBtn.Click += new System.EventHandler(this.szamolBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.BackColor = System.Drawing.Color.Red;
            this.kilepBtn.ForeColor = System.Drawing.Color.White;
            this.kilepBtn.Location = new System.Drawing.Point(411, 310);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(147, 50);
            this.kilepBtn.TabIndex = 5;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = false;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(252, 206);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(217, 20);
            this.resultBox.TabIndex = 6;
            this.resultBox.Text = "Eredmény: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.szamolBtn);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.Button szamolBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.TextBox resultBox;
    }
}

