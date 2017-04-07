/**
* \file Ellipse.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief class for drawing Ellipses
*/



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETPaint {
    /**
    * \class Ellipse
    * \breif <b>Description :</b> class for drawing Ellipses
    * \author Zach Walters
    */
    public class Ellipse : Rectangle {



        /**
        * \brief <b>Ellipse</b> - constructor for Ellipse
        * \details sets variables to parameters
        * \param float thickness - the thickness of the line/outlint
        * \param Color line - the color of the line/outline
        * \param Color fill - the color of the inside fill of the shape
        * \return none
        */
        public Ellipse(float thickness, Color line, Color fill) : base(thickness, line, fill) {
            
        }



        /**
        * \brief <b>Draw</b> - draw the class's shape
        * \details draw the class's shape which in this class is a Ellipse
        * \param Graphics gr - A graphics object used for drawing to the bitmap image
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \return none
        */
        public override void Draw(Graphics gr, Point start, Point end) {

            base.correctCordinates(ref start, ref end);

            Pen p = new Pen(lineColor);
            p.Width = lineThickness;
            SolidBrush sb = new SolidBrush(fillColor);
            gr.FillEllipse(sb, start.X, start.Y, end.X - start.X, end.Y - start.Y);
            gr.DrawEllipse(p, start.X, start.Y, end.X - start.X, end.Y - start.Y);
        }
    }
}
