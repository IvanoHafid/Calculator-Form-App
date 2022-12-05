namespace CalculatorFormApp
{
    partial class CalcDisplay
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Hasil = new System.Windows.Forms.GroupBox();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.Hasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(756, 344);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Hasil
            // 
            this.Hasil.Controls.Add(this.listBox1);
            this.Hasil.Location = new System.Drawing.Point(20, 12);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(768, 377);
            this.Hasil.TabIndex = 1;
            this.Hasil.TabStop = false;
            this.Hasil.Text = "Hasil Operasi";
            // 
            // btn_Hitung
            // 
            this.btn_Hitung.Location = new System.Drawing.Point(20, 395);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(169, 43);
            this.btn_Hitung.TabIndex = 1;
            this.btn_Hitung.Text = "Hitung";
            this.btn_Hitung.UseVisualStyleBackColor = true;
            this.btn_Hitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // CalcDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Hitung);
            this.Controls.Add(this.Hasil);
            this.Name = "CalcDisplay";
            this.Text = "Calculator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Hasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox Hasil;
        private System.Windows.Forms.Button btn_Hitung;
    }
}

