﻿namespace PictureApp
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
            this.pcbZdjecie = new System.Windows.Forms.PictureBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnDelPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbZdjecie)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbZdjecie
            // 
            this.pcbZdjecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbZdjecie.Location = new System.Drawing.Point(76, 48);
            this.pcbZdjecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbZdjecie.Name = "pcbZdjecie";
            this.pcbZdjecie.Size = new System.Drawing.Size(859, 495);
            this.pcbZdjecie.TabIndex = 0;
            this.pcbZdjecie.TabStop = false;
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(475, 564);
            this.btnAddPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(75, 49);
            this.btnAddPic.TabIndex = 1;
            this.btnAddPic.Text = "Dodaj Zdjęcie";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnDelPic
            // 
            this.btnDelPic.Location = new System.Drawing.Point(570, 564);
            this.btnDelPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelPic.Name = "btnDelPic";
            this.btnDelPic.Size = new System.Drawing.Size(75, 49);
            this.btnDelPic.TabIndex = 0;
            this.btnDelPic.Text = "Usuń Zdjęcie";
            this.btnDelPic.UseVisualStyleBackColor = true;
            this.btnDelPic.Click += new System.EventHandler(this.btnDelPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 624);
            this.Controls.Add(this.btnDelPic);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.pcbZdjecie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbZdjecie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbZdjecie;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnDelPic;
    }
}

