/**
* \file DrawShape.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief abstract base class for drawing shapes
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace SETPaint {
    /**
    * \class line
    * \breif <b>Description :</b> abstract base class for drawing shapes
    * \author Zach Walters
    */
    public abstract class DrawShape {

        public float lineThickness { get; set; } ///< the thickness of the line/outline
        public Color lineColor { get; set; } ///< the color of the line/outline
        public Color fillColor { get; set; } ///< the color of the inside fill of the shape
        


        /**
        * \brief <b>DrawShape</b> - constructor for DrawShape
        * \details sets variables to parameters
        * \param float thickness - the thickness of the line/outlint
        * \param Color line - the color of the line/outline
        * \param Color fill - the color of the inside fill of the shape
        * \return none
        */
        public DrawShape(float thickness, Color line, Color fill) {

            lineThickness = thickness;
            lineColor = line;
            fillColor = fill;
        }



        /**
        * \brief <b>Draw</b> - draw the class's shape
        * \details draw the class's shape, abstract method
        * \param Graphics gr - A graphics object used for drawing to the bitmap image
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \return none
        */
        public abstract void Draw(Graphics gr, Point start, Point end);



        /**
        * \brief <b>rubberBand</b> - draw a dotted outline of the shape
        * \details draw a dotted outline of the shape, abstract method
        * \param Point start - the mouse down point
        * \param Point end - the mouse up point
        * \param PaintEventArgs e - access to Graphics to draw a rectangle
        * \return none
        */
        public abstract void rubberBand(Point start, Point end, PaintEventArgs e);

    }
}
