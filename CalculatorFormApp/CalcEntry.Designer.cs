namespace CalculatorFormApp
{
    partial class CalcEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.btn_Proses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmB_Operasi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(134, 95);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(267, 26);
            this.textA.TabIndex = 4;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(134, 149);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(267, 26);
            this.textB.TabIndex = 5;
            // 
            // btn_Proses
            // 
            this.btn_Proses.Location = new System.Drawing.Point(217, 191);
            this.btn_Proses.Name = "btn_Proses";
            this.btn_Proses.Size = new System.Drawing.Size(98, 36);
            this.btn_Proses.TabIndex = 6;
            this.btn_Proses.Text = "Proses";
            this.btn_Proses.UseVisualStyleBackColor = true;
            this.btn_Proses.Click += new System.EventHandler(this.btn_Proses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operasi";
            // 
            // CmB_Operasi
            // 
            this.CmB_Operasi.FormattingEnabled = true;
            this.CmB_Operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Pembagian",
            "Perkalian"});
            this.CmB_Operasi.Location = new System.Drawing.Point(134, 38);
            this.CmB_Operasi.Name = "CmB_Operasi";
            this.CmB_Operasi.Size = new System.Drawing.Size(267, 28);
            this.CmB_Operasi.TabIndex = 9;
            this.CmB_Operasi.SelectedIndexChanged += new System.EventHandler(this.CmB_Operasi_SelectedIndexChanged);
            // 
            // CalcEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 248);
            this.Controls.Add(this.CmB_Operasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Proses);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalcEntry";
            this.Text = "CalcEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Button btn_Proses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmB_Operasi;
    }
}