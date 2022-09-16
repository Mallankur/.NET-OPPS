using System.Collections;
using System.Collections.Generic;

namespace ServerChat_piolet_projet
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannel;
        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            foreach (var i in _notificationChannel)
            {
                i.Send(new Message());

            }
        }

        public void RegisterNotificationChannel(INotificationChannel i)
        {
            _notificationChannel.Add(i);
        }
    }
}
