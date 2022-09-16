using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace oppes
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
