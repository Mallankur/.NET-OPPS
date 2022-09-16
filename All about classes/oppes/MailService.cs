    using System;


namespace oppes
{
    public class MailService
    {
        public void send (Mail  mail)
        {
            Console.WriteLine("Sending email");
        }

        internal void Send(Mail mail)
        {
            throw new NotImplementedException();
        }
    }

}




