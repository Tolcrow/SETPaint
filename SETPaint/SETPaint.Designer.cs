/**
* \file SETPaint.Designer.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief user interface for SETPaint
*/



using System;

namespace SETPaint {
    partial class SETPaint {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SETPaint));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.lineTool = new System.Windows.Forms.ToolStripButton();
            this.rectangleTool = new System.Windows.Forms.ToolStripButton();
            this.ellipsesTool = new System.Windows.Forms.ToolStripButton();
            this.toolBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lineColorPicker = new System.Windows.Forms.ToolStripButton();
            this.fillColorPicker = new System.Windows.Forms.ToolStripButton();
            this.lineThickness = new System.Windows.Forms.ToolStripComboBox();
            this.pictureEdit = new System.Windows.Forms.PictureBox();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit)).BeginInit();
            this.scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(670, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(103, 22);
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(103, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(103, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(103, 22);
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMousePosition});
            this.statusBar.Location = new System.Drawing.Point(0, 549);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(670, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarMousePosition
            // 
            this.statusBarMousePosition.Name = "statusBarMousePosition";
            this.statusBarMousePosition.Size = new System.Drawing.Size(0, 17);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineTool,
            this.rectangleTool,
            this.ellipsesTool,
            this.toolBarSeparator,
            this.lineColorPicker,
            this.fillColorPicker,
            this.lineThickness});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(670, 25);
            this.toolBar.TabIndex = 3;
            this.toolBar.Text = "toolStrip1";
            // 
            // lineTool
            // 
            this.lineTool.Checked = true;
            this.lineTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineTool.Image = ((System.Drawing.Image)(resources.GetObject("lineTool.Image")));
            this.lineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineTool.Name = "lineTool";
            this.lineTool.Size = new System.Drawing.Size(23, 22);
            this.lineTool.Text = "Line Tool";
            this.lineTool.Click += new System.EventHandler(this.lineTool_Click);
            // 
            // rectangleTool
            // 
            this.rectangleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleTool.Image = ((System.Drawing.Image)(resources.GetObject("rectangleTool.Image")));
            this.rectangleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleTool.Name = "rectangleTool";
            this.rectangleTool.Size = new System.Drawing.Size(23, 22);
            this.rectangleTool.Text = "Rectangle Tool";
            this.rectangleTool.Click += new System.EventHandler(this.rectangleTool_Click);
            // 
            // ellipsesTool
            // 
            this.ellipsesTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipsesTool.Image = ((System.Drawing.Image)(resources.GetObject("ellipsesTool.Image")));
            this.ellipsesTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipsesTool.Name = "ellipsesTool";
            this.ellipsesTool.Size = new System.Drawing.Size(23, 22);
            this.ellipsesTool.Text = "Ellipses Tool";
            this.ellipsesTool.Click += new System.EventHandler(this.ellipsesTool_Click);
            // 
            // toolBarSeparator
            // 
            this.toolBarSeparator.Name = "toolBarSeparator";
            this.toolBarSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // lineColorPicker
            // 
            this.lineColorPicker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("lineColorPicker.Image")));
            this.lineColorPicker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineColorPicker.Name = "lineColorPicker";
            this.lineColorPicker.Size = new System.Drawing.Size(65, 22);
            this.lineColorPicker.Text = "Line Color";
            this.lineColorPicker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineColorPicker.Click += new System.EventHandler(this.lineColorPicker_Click);
            // 
            // fillColorPicker
            // 
            this.fillColorPicker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillColorPicker.Enabled = false;
            this.fillColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("fillColorPicker.Image")));
            this.fillColorPicker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorPicker.Name = "fillColorPicker";
            this.fillColorPicker.Size = new System.Drawing.Size(58, 22);
            this.fillColorPicker.Text = "Fill Color";
            this.fillColorPicker.Click += new System.EventHandler(this.fillColorPicker_Click);
            // 
            // lineThickness
            // 
            this.lineThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineThickness.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12",
            "15",
            "18",
            "21",
            "24",
            "27",
            "30"});
            this.lineThickness.Name = "lineThickness";
            this.lineThickness.Size = new System.Drawing.Size(121, 25);
            this.lineThickness.ToolTipText = "Line Thickness";
            this.lineThickness.SelectedIndexChanged += new System.EventHandler(this.lineThickness_Change);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Size = new System.Drawing.Size(448, 258);
            this.pictureEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEdit.TabIndex = 4;
            this.pictureEdit.TabStop = false;
            this.pictureEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureEdit_Paint);
            this.pictureEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureEdit_MouseDown);
            this.pictureEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureEdit_MouseMove);
            this.pictureEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureEdit_MouseUp);
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.pictureEdit);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 49);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(670, 500);
            this.scrollPanel.TabIndex = 5;
            // 
            // SETPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 571);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "SETPaint";
            this.ShowInTaskbar = false;
            this.Text = "untitled - SETPaint";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton lineTool;
        private System.Windows.Forms.PictureBox pictureEdit;
        private System.Windows.Forms.ToolStripButton rectangleTool;
        private System.Windows.Forms.ToolStripButton ellipsesTool;
        private System.Windows.Forms.ToolStripSeparator toolBarSeparator;
        private System.Windows.Forms.ToolStripButton lineColorPicker;
        private System.Windows.Forms.ToolStripButton fillColorPicker;
        private System.Windows.Forms.ToolStripComboBox lineThickness;
        private System.Windows.Forms.ToolStripStatusLabel statusBarMousePosition;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Panel scrollPanel;
    }
}

