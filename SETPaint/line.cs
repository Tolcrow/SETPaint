/**
* \file line.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief class for drawing lines
*/



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETPaint {
    /**
    * \class line
    * \breif <b>Description :</b> class for drawing lines
    * \author Zach Walters
    */
    class line : DrawShape {



        /**
        * \brief <b>line</b> - Function Purpose
        * \details Detailed functionality
        * \param Function paramater and description
        * \return Describe return
        * \retval Return value and value description (used for TRUE/FALSE)
        */
        public line(float thickness, Color line, Color fillColor) : base(thickness, line, fillColor) {

        }



        /**
        * \brief <b>Draw</b> - draw the class's shape
        * \details draw the class's shape which in this class is a Line
        * \param Graphics gr - A graphics object used for drawing to the bitmap image
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \return none
        */
        public override void Draw(Graphics gr, Point start, Point end) {


            Pen p = new Pen(lineColor);
            p.Width = lineThickness;
            gr.DrawLine(p, start.X, start.Y, end.X, end.Y);
        }



        /**
        * \brief <b>rubberBand</b> - draw a dotted linw
        * \details draw a dotted line where the line will be drawn
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \param PaintEventArgs e - access to Graphics to draw a line
        * \return none
        */
        public override void rubberBand(Point start, Point end, PaintEventArgs e) {

            Pen p = new Pen(Color.Gray);
            p.DashPattern = new float[2] { 5, 5 };
            e.Graphics.DrawLine(p, start.X, start.Y, end.X, end.Y);
        }
    }
}
