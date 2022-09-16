using System;
using System.Security.Cryptography.X509Certificates;

namespace oppes
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

      

        public void start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("stopwatch is already running");
            }
          
                _startTime = DateTime.Now;
                _isRunning=true;

        }
        public void stop()
        {
            if (!_isRunning)
            {
                _endTime= DateTime.Now;
                _isRunning = false; 
            }
            
            

        }
        public TimeSpan getIntrval()
        {
            var duration = _endTime- _startTime;
            return duration;

        }

    }
}
