/**
* \file Dimensions.Designer.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief user interface for Dimensions window
*/


namespace SETPaint {
    partial class Dimensions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dimensions));
            this.widthTextBoxDescription = new System.Windows.Forms.Label();
            this.heightTextBoxDescription = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.pageDescription = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // widthTextBoxDescription
            // 
            this.widthTextBoxDescription.AutoSize = true;
            this.widthTextBoxDescription.Location = new System.Drawing.Point(25, 49);
            this.widthTextBoxDescription.Name = "widthTextBoxDescription";
            this.widthTextBoxDescription.Size = new System.Drawing.Size(41, 13);
            this.widthTextBoxDescription.TabIndex = 0;
            this.widthTextBoxDescription.Text = "Width: ";
            // 
            // heightTextBoxDescription
            // 
            this.heightTextBoxDescription.AutoSize = true;
            this.heightTextBoxDescription.Location = new System.Drawing.Point(25, 98);
            this.heightTextBoxDescription.Name = "heightTextBoxDescription";
            this.heightTextBoxDescription.Size = new System.Drawing.Size(44, 13);
            this.heightTextBoxDescription.TabIndex = 1;
            this.heightTextBoxDescription.Text = "Height: ";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(75, 46);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 2;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(75, 95);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(127, 153);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pageDescription
            // 
            this.pageDescription.AutoSize = true;
            this.pageDescription.Location = new System.Drawing.Point(25, 19);
            this.pageDescription.Name = "pageDescription";
            this.pageDescription.Size = new System.Drawing.Size(59, 13);
            this.pageDescription.TabIndex = 5;
            this.pageDescription.Text = "Image Size";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(208, 153);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Dimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 188);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pageDescription);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.heightTextBoxDescription);
            this.Controls.Add(this.widthTextBoxDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dimensions";
            this.Text = "Dimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthTextBoxDescription;
        private System.Windows.Forms.Label heightTextBoxDescription;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label pageDescription;
        private System.Windows.Forms.Button cancelButton;
    }
}