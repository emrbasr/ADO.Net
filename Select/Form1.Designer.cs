﻿namespace Select
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
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.ItemHeight = 15;
            this.lstCalisanlar.Location = new System.Drawing.Point(34, 17);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(248, 334);
            this.lstCalisanlar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(34, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bilgileri Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCalisanlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCalisanlar;
        private System.Windows.Forms.Button button1;
    }
}
