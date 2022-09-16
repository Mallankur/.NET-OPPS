using System;

namespace oppes
{
    public class UiControl
    {
        public string Name { get; set; }
       // public Size Size { get; set; }
       // public Position TopLeft  { get; set; }


        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}




