using System;
using System.Threading;

namespace extra_advance_topic_of_csharp
{
    public class videoEncoder
    {
        //1- define a delegate
        //2- Define an event based on that delegate
        //3- Raise the event 
        public delegate void ViodeoEventHandler(object source , EventArgs args);
        public event ViodeoEventHandler ViodeoEncoded; 
        public void Encode (Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            OnVideoEncode();

        }
        protected virtual void OnVideoEncode()
        {   

        }

    }
}
