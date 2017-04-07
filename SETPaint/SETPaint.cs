/**
* \file SETPaint.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief a drawing tool for editing images
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace SETPaint {
    /**
    * \class SETPaint
    * \breif <b>Description :</b> a drawing tool for editing images
    * \author Zach Walters
    */
    public partial class SETPaint : Form {

        const int kDefaultWidth = 640;
        const int kDefaultHeight = 480;
        const int kTopRightPoint = 0;
        const int kStepOverCharacter = 1;
        const float kDefaultThickness = 6.0f;
        const KnownColor kDefaultLineColor = KnownColor.Black;
        const KnownColor kDefaultfillColor = KnownColor.Blue;
        const KnownColor kBackgroundColor = KnownColor.White;

        Bitmap bmpImage = null;
        Graphics imageGraphics = null;
        Point mousePosition = new Point();
        Point startPosition = new Point();
        bool mouseDown = false;
        DrawShape tool = null;


        public SETPaint() {
            InitializeComponent();

            scrollPanel.Controls.Add(pictureEdit);
            lineColorPicker.ForeColor = Color.FromKnownColor(kDefaultLineColor);
            fillColorPicker.ForeColor = Color.FromKnownColor(kDefaultfillColor);

            bmpImage = new Bitmap(kDefaultWidth, kDefaultHeight);
            pictureEdit.Image = bmpImage;
            imageGraphics = Graphics.FromImage(bmpImage);
            SolidBrush sb = new SolidBrush(Color.FromKnownColor(kBackgroundColor));
            imageGraphics.FillRectangle(sb, kTopRightPoint, kTopRightPoint, kDefaultWidth, kDefaultHeight);

            tool = new line(kDefaultThickness, Color.FromKnownColor(kDefaultLineColor), Color.FromKnownColor(kDefaultfillColor));
        }



        /**
        * \brief <b>pictureEdit_MouseUp</b> - record the end position and draw the shape
        * \details record the end position and draw the shape
        * \param object sender - reference to the object that raised the event.  not used
        * \param MouseEventArgs e - contains the mouses location
        * \return 
        */
        private void pictureEdit_MouseUp(object sender, MouseEventArgs e) {

            mouseDown = false;
            Point end = new Point(e.X, e.Y);
            tool.Draw(imageGraphics, startPosition, end);
            pictureEdit.Image = bmpImage;
        }



        /**
        * \brief <b>pictureEdit_MouseDown</b> - record the starting position
        * \details record the starting position
        * \param object sender - reference to the object that raised the event.  not used
        * \param MouseEventArgs e - contains the mouses location
        * \return 
        */
        private void pictureEdit_MouseDown(object sender, MouseEventArgs e) {

            mouseDown = true;
            startPosition.X = e.X;
            startPosition.Y = e.Y;
        }



        /**
        * \brief <b>pictureEdit_MouseMove</b> - record the mouse's position
        * \details record the mouse's position and use it to display status information
        * \param object sender - reference to the object that raised the event.  not used
        * \param MouseEventArgs e - contains the mouses location
        * \return none
        */
        private void pictureEdit_MouseMove(object sender, MouseEventArgs e) {

            mousePosition = new Point(e.X, e.Y);
            pictureEdit.Invalidate();

            if (mouseDown == true) {

                statusBarMousePosition.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString() +
                    "  Width: " + Math.Abs(startPosition.X - e.X).ToString() + 
                    " Height: " + Math.Abs(startPosition.Y - e.Y).ToString();
            }
            else {

                statusBarMousePosition.Text = "";
            }
        }



        /**
        * \brief <b>menuOpen_Click</b> - open a bitmap file
        * \details open a bitmap file
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void menuOpen_Click(object sender, EventArgs e) {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "BMP Image|*.bmp";
            openFile.ShowDialog();

            if ((openFile.FileName != null) && (openFile.FileName != "")) {

                byte[] bytes = System.IO.File.ReadAllBytes(openFile.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                bmpImage = new Bitmap(Image.FromStream(ms));
                pictureEdit.Image = bmpImage;
                imageGraphics = Graphics.FromImage(bmpImage);
                this.Text = openFile.FileName.Substring(openFile.FileName.LastIndexOf(@"\") + kStepOverCharacter) + " - SETPaint";
            }
        }



        /**
        * \brief <b>lineColorPicker_Click</b> - prompt the user to select a color
        * \details prompt the user to select a color for the lineColor
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void lineColorPicker_Click(object sender, EventArgs e) {

            ColorDialog selectColor = new ColorDialog();
            selectColor.ShowDialog();

            tool.lineColor = selectColor.Color;
            lineColorPicker.ForeColor = selectColor.Color;
        }



        /**
        * \brief <b>fillColorPicker_Click</b> - prompt the user to select a color
        * \details prompt the user to select a color for the fillColor
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void fillColorPicker_Click(object sender, EventArgs e) {

            ColorDialog selectColor = new ColorDialog();
            selectColor.ShowDialog();

            tool.fillColor = selectColor.Color;
            fillColorPicker.ForeColor = selectColor.Color;
        }



        /**
        * \brief <b>lineTool_Click</b> - set the tool to a Line
        * \details set the tool to a Line
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void lineTool_Click(object sender, EventArgs e) {

            DrawShape tempHold = tool;
            tool = new line(tempHold.lineThickness, tempHold.lineColor, tempHold.fillColor);
            unCheckAll();
            lineTool.Checked = true;
        }



        /**
        * \brief <b>rectangleTool_Click</b> - set the tool to a Rectangle
        * \details set the tool to a Rectangle
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void rectangleTool_Click(object sender, EventArgs e) {

            DrawShape tempHold = tool;
            tool = new Rectangle(tempHold.lineThickness, tempHold.lineColor, tempHold.fillColor);
            unCheckAll();
            rectangleTool.Checked = true;
            fillColorPicker.Enabled = true;
        }



        /**
        * \brief <b>ellipsesTool_Click</b> - set the tool to a Ellipse
        * \details set the tool to a Ellipse
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void ellipsesTool_Click(object sender, EventArgs e) {

            DrawShape tempHold = tool;
            tool = new Ellipse(tempHold.lineThickness, tempHold.lineColor, tempHold.fillColor);
            unCheckAll();
            ellipsesTool.Checked = true;
            fillColorPicker.Enabled = true;
        }



        /**
        * \brief <b>unCheckAll</b> - uncheck all menu items
        * \details uncheck all menu items and disable the fill color picker
        * \param none
        * \return none
        */
        private void unCheckAll() {

            lineTool.Checked = false;
            rectangleTool.Checked = false;
            ellipsesTool.Checked = false;
            fillColorPicker.Enabled = false;
        }



        /**
        * \brief <b>pictureEdit_Paint</b> - draw a dotted outline when the
        * \details 
        * \param object sender - reference to the object that raised the event.  not used
        * \param PaintEventArgs e - access to Graphics to draw a dotted outline
        * \return none
        */
        private void pictureEdit_Paint(object sender, PaintEventArgs e) {

            if (mouseDown == true) {

                tool.rubberBand(startPosition, mousePosition, e);
            }
        }



        /**
        * \brief <b>aboutToolStripMenuItem_Click</b> - show the about box
        * \details show the about box
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            
            SETPaintAboutBox about = new SETPaintAboutBox();
            about.ShowDialog();
        }



        /**
        * \brief <b>saveToolStripMenuItem_Click</b> - save the image
        * \details save the image as a .bmp file
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "BMP Image|*.bmp";
            saveFile.DefaultExt = ".bmp";
            saveFile.ShowDialog();

            if ((saveFile.FileName != null) && (saveFile.FileName != "")) {

                Bitmap saveImage = new Bitmap(pictureEdit.Image);
                saveImage.Save(saveFile.FileName, ImageFormat.Bmp);
                this.Text = saveFile.FileName.Substring(saveFile.FileName.LastIndexOf(@"\") + kStepOverCharacter) + " - SETPaint";
            }
        }



        /**
        * \brief <b>menuNew_Click</b> - create a new image
        * \details create a new image and prompt the user for the size
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void menuNew_Click(object sender, EventArgs e) {
            
            ConfirmNew confirm = new ConfirmNew();
            confirm.ShowDialog();

            if (confirm.DialogResult == DialogResult.OK) {

                Dimensions imageDimensions = new Dimensions();
                imageDimensions.ShowDialog();
                if (imageDimensions.DialogResult == DialogResult.OK) {

                    bmpImage = new Bitmap(imageDimensions.ImageWidth, imageDimensions.ImageHeight);
                    pictureEdit.Image = bmpImage;
                    imageGraphics = Graphics.FromImage(bmpImage);
                    SolidBrush fillBrush = new SolidBrush(Color.White);
                    imageGraphics.FillRectangle(fillBrush, kTopRightPoint, kTopRightPoint, imageDimensions.ImageWidth, imageDimensions.ImageHeight);

                    this.Text = "untitled - SETPaint";
                }
            }
        }



        /**
        * \brief <b>menuClose_Click</b> - close the application
        * \details close the application
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void menuClose_Click(object sender, EventArgs e) {

            Close();
        }



        /**
        * \brief <b>lineThickness_Change</b> - set the shapes line thickness
        * \details sets the shapes line thickness whenever the thickness changes
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void lineThickness_Change(object sender, EventArgs e) {
            
            tool.lineThickness = float.Parse(lineThickness.Text);
        }
    }
}
