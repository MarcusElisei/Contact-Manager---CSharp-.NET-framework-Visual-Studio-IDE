﻿namespace HarissAndSonsContactManager
{
    partial class ContactMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactMenu));
            this.btn_Personal = new System.Windows.Forms.Button();
            this.btnBusinessContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Personal
            // 
            this.btn_Personal.Location = new System.Drawing.Point(384, 150);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(151, 37);
            this.btn_Personal.TabIndex = 0;
            this.btn_Personal.Text = "Personal Contact";
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.UseWaitCursor = true;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click);
            // 
            // btnBusinessContact
            // 
            this.btnBusinessContact.Location = new System.Drawing.Point(128, 150);
            this.btnBusinessContact.Name = "btnBusinessContact";
            this.btnBusinessContact.Size = new System.Drawing.Size(151, 35);
            this.btnBusinessContact.TabIndex = 1;
            this.btnBusinessContact.Text = "Business Contact";
            this.btnBusinessContact.UseVisualStyleBackColor = true;
            this.btnBusinessContact.Click += new System.EventHandler(this.btnBusinessContact_Click);
            // 
            // ContactMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 352);
            this.Controls.Add(this.btnBusinessContact);
            this.Controls.Add(this.btn_Personal);
            this.Name = "ContactMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Button btnBusinessContact;
    }
}

