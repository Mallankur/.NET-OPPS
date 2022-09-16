using System;


namespace ServerChat_piolet_projet
{
    public class SmsNotificationChannel : INotificationChannel
    {
         public void Send(Message message)
        {
            Console.WriteLine("Sending SMS..............");
        }

    }
}
