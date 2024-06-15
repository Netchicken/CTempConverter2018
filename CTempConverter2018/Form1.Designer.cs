#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace CTempConverter2018
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.pBarFah = new System.Windows.Forms.ProgressBar();
            this.pBarCel = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFarToCel = new System.Windows.Forms.Button();
            this.btncelTofah = new System.Windows.Forms.Button();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Location = new System.Drawing.Point(453, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(482, 71);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Temperature Converter";
            // 
            // pBarFah
            // 
            this.pBarFah.Location = new System.Drawing.Point(438, 566);
            this.pBarFah.Maximum = 200;
            this.pBarFah.Name = "pBarFah";
            this.pBarFah.Size = new System.Drawing.Size(679, 56);
            this.pBarFah.Step = 1;
            this.pBarFah.TabIndex = 16;
            // 
            // pBarCel
            // 
            this.pBarCel.Location = new System.Drawing.Point(438, 450);
            this.pBarCel.Maximum = 200;
            this.pBarCel.Name = "pBarCel";
            this.pBarCel.Size = new System.Drawing.Size(679, 56);
            this.pBarCel.Step = 1;
            this.pBarCel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fahrenheit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Celsius";
            // 
            // btnFarToCel
            // 
            this.btnFarToCel.Location = new System.Drawing.Point(730, 247);
            this.btnFarToCel.Margin = new System.Windows.Forms.Padding(8);
            this.btnFarToCel.Name = "btnFarToCel";
            this.btnFarToCel.Size = new System.Drawing.Size(261, 60);
            this.btnFarToCel.TabIndex = 12;
            this.btnFarToCel.Text = "Far to Cel";
            this.btnFarToCel.UseVisualStyleBackColor = true;
            this.btnFarToCel.Click += new System.EventHandler(this.btnFarToCel_Click);
            // 
            // btncelTofah
            // 
            this.btncelTofah.Location = new System.Drawing.Point(730, 128);
            this.btncelTofah.Margin = new System.Windows.Forms.Padding(8);
            this.btncelTofah.Name = "btncelTofah";
            this.btncelTofah.Size = new System.Drawing.Size(261, 60);
            this.btncelTofah.TabIndex = 11;
            this.btncelTofah.Text = "Cel to Fah";
            this.btncelTofah.UseVisualStyleBackColor = true;
            this.btncelTofah.Click += new System.EventHandler(this.btncelTofah_Click);
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(403, 247);
            this.txtFah.Margin = new System.Windows.Forms.Padding(8);
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(268, 49);
            this.txtFah.TabIndex = 10;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(403, 131);
            this.txtCel.Margin = new System.Windows.Forms.Padding(8);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(268, 49);
            this.txtCel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 700);
            this.Controls.Add(this.pBarFah);
            this.Controls.Add(this.pBarCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFarToCel);
            this.Controls.Add(this.btncelTofah);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.ProgressBar pBarFah;
        private System.Windows.Forms.ProgressBar pBarCel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFarToCel;
        private System.Windows.Forms.Button btncelTofah;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.TextBox txtCel;
    }
}

