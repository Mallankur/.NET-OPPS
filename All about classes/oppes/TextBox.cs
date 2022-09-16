using System;

namespace oppes
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            Console.WriteLine("dragone");

        }
        public void Drop()
        {
            Console.WriteLine("Drope hua  ");
        }

    }
    
}




