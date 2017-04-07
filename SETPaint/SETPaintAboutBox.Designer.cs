/**
* \file SETPaintAboutBox.Designer.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief user interface for SetPaint's about box
*/



namespace SETPaint {
    partial class SETPaintAboutBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SETPaintAboutBox));
            this.close = new System.Windows.Forms.Button();
            this.SetPaintIcon = new System.Windows.Forms.PictureBox();
            this.SETPaintInformation = new System.Windows.Forms.RichTextBox();
            this.SETPaintDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SetPaintIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(331, 245);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SetPaintIcon
            // 
            this.SetPaintIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetPaintIcon.BackgroundImage")));
            this.SetPaintIcon.Location = new System.Drawing.Point(12, 12);
            this.SetPaintIcon.Name = "SetPaintIcon";
            this.SetPaintIcon.Size = new System.Drawing.Size(128, 256);
            this.SetPaintIcon.TabIndex = 1;
            this.SetPaintIcon.TabStop = false;
            // 
            // SETPaintInformation
            // 
            this.SETPaintInformation.Location = new System.Drawing.Point(146, 12);
            this.SETPaintInformation.Name = "SETPaintInformation";
            this.SETPaintInformation.ReadOnly = true;
            this.SETPaintInformation.Size = new System.Drawing.Size(260, 116);
            this.SETPaintInformation.TabIndex = 2;
            this.SETPaintInformation.Text = "SetPaint\n\nVersion 1.0\n\nCopyright Zach Walters\n\nConestoga Collage";
            // 
            // SETPaintDescription
            // 
            this.SETPaintDescription.Location = new System.Drawing.Point(146, 134);
            this.SETPaintDescription.Name = "SETPaintDescription";
            this.SETPaintDescription.ReadOnly = true;
            this.SETPaintDescription.Size = new System.Drawing.Size(260, 105);
            this.SETPaintDescription.TabIndex = 3;
            this.SETPaintDescription.Text = "SETPaint is a drawing tool for editing images.  SETPaint can draw lines, rectangl" +
    "es, and ellipses.";
            // 
            // SETPaintAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 278);
            this.Controls.Add(this.SETPaintDescription);
            this.Controls.Add(this.SETPaintInformation);
            this.Controls.Add(this.SetPaintIcon);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SETPaintAboutBox";
            this.Text = "About SetPaint";
            ((System.ComponentModel.ISupportInitialize)(this.SetPaintIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox SetPaintIcon;
        private System.Windows.Forms.RichTextBox SETPaintInformation;
        private System.Windows.Forms.RichTextBox SETPaintDescription;
    }
}