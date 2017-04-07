/**
* \file Rectangle.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief class for drawing Rectangles
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
    * \class Rectangle
    * \breif <b>Description :</b> class for drawing Rectangles
    * \author Zach Walters
    */
    public class Rectangle : DrawShape {

        /**
        * \brief <b>Rectangle</b> - constructor for Rectangle
        * \details sets variables to parameters
        * \param float thickness - the thickness of the line/outlint
        * \param Color line - the color of the line/outline
        * \param Color fill - the color of the inside fill of the shape
        * \return none
        */
        public Rectangle(float thickness, Color line, Color fill) : base(thickness, line, fill) {
            
        }



        /**
        * \brief <b>Draw</b> - draw the class's shape
        * \details draw the class's shape which in this class is a rectangle
        * \param Graphics gr - A graphics object used for drawing to the bitmap image
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \return none
        */
        public override void Draw(Graphics gr, Point start, Point end) {

            correctCordinates(ref start, ref end);

            Pen p = new Pen(lineColor);
            p.Width = lineThickness;
            SolidBrush sb = new SolidBrush(fillColor);
            gr.FillRectangle(sb, start.X, start.Y, end.X - start.X, end.Y - start.Y);
            gr.DrawRectangle(p, start.X, start.Y, end.X - start.X, end.Y - start.Y);
        }



        /**
        * \brief <b>rubberBand</b> - draw a dotted outline of the shape
        * \details draw a dotted outline of the shape
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \param PaintEventArgs e - access to Graphics to draw a rectangle
        * \return none
        */
        public override void rubberBand(Point start, Point end, PaintEventArgs e) {

            Point newStart = new Point(start.X, start.Y);
            Point newEnd = new Point(end.X, end.Y);

            correctCordinates(ref newStart, ref newEnd);
            
            Pen p = new Pen(Color.Gray);
            p.DashPattern = new float[2] { 5, 5 };
            e.Graphics.DrawRectangle(p, newStart.X, newStart.Y, newEnd.X - newStart.X, newEnd.Y - newStart.Y);
        }



        /**
        * \brief <b>correctCordinates</b> - moves the start position to the upper left and the end position to the lower right
        * \details rectangles can only be drawn from the upper left to the lower right. If the end position
        * is higher or to the right of the starting position, the points X/Y values must be swapped.
        * \param ref Point start - the mouse down point
        * \param ref Point end - the mouse up point
        * \return none - the parameters themselves are modified/returned
        */
        protected void correctCordinates(ref Point start, ref Point end) {
            
            if (end.X < start.X) {

                int temp = end.X;
                end.X = start.X;
                start.X = temp;
            }
            if (end.Y < start.Y) {

                int temp = end.Y;
                end.Y = start.Y;
                start.Y = temp;
            }
        }
    }
}
