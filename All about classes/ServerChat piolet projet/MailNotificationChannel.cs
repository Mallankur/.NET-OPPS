    using System;
namespace ServerChat_piolet_projet
{ 
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send (Message message)
        {
            Console.WriteLine( "Sending mail...." );
        }

    }
}
