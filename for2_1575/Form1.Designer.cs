namespace for2_1575
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            lbSayi = new ListBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SpringGreen;
            btnEkle.Location = new Point(178, 66);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(134, 45);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lbSayi
            // 
            lbSayi.FormattingEnabled = true;
            lbSayi.ItemHeight = 20;
            lbSayi.Location = new Point(12, 19);
            lbSayi.Name = "lbSayi";
            lbSayi.Size = new Size(150, 404);
            lbSayi.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(329, 442);
            Controls.Add(lbSayi);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private ListBox lbSayi;
    }
}