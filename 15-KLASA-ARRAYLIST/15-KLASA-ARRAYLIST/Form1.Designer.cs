﻿namespace _15_KLASA_ARRAYLIST
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
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBoxNovi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(120, 55);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(148, 39);
            this.buttonNovi.TabIndex = 0;
            this.buttonNovi.Text = "Novi automobil";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(332, 144);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(110, 35);
            this.buttonUnesi.TabIndex = 1;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // textBoxNovi
            // 
            this.textBoxNovi.Enabled = false;
            this.textBoxNovi.Location = new System.Drawing.Point(120, 144);
            this.textBoxNovi.Name = "textBoxNovi";
            this.textBoxNovi.Size = new System.Drawing.Size(171, 26);
            this.textBoxNovi.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(120, 199);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 241);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(120, 498);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(148, 53);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši listu";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 586);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNovi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.buttonNovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBoxNovi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonObrisi;
    }
}

