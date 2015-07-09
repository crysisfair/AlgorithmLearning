/*
 * Find the total area covered by two rectilinear rectangles in a 2D plane.
 * 
 * Each rectangle is defined by its bottom left corner and top right corner as shown in the figure.
 * Rectangle Area
 * 
 * Assume that the total area is never beyond the maximum possible value of int.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Leetcode
{
    class RectangleArea
    {
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            int area1 = (C - A) * (D - B);
            int area2 = (G - E) * (H - F);

            int area = 0;

            int startx = Math.Max(A, E);
            int endx = Math.Min(C, G);
            int starty = Math.Max(B, F);
            int endy = Math.Min(D, H);

            if(endx > startx && endy > starty)
                area = (endx - startx) * (endy - starty);

            return area1 + area2 - area;
        }
    }
}
