namespace SETPaint {
    partial class ConfirmNew {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmNew));
            this.message = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(359, 13);
            this.message.TabIndex = 0;
            this.message.Text = "This action could cause a loss of data. Are you sure you want to continue?";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(296, 129);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "No";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Continue
            // 
            this.Continue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Continue.Location = new System.Drawing.Point(215, 129);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Yes";
            this.Continue.UseVisualStyleBackColor = true;
            // 
            // ConfirmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 164);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmNew";
            this.Text = "Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Continue;
    }
}