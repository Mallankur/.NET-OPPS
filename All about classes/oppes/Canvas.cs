using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace oppes
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw();

            }
        }





                                                                                                                    

    }
}
