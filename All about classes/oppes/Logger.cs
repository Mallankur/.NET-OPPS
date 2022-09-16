using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace oppes
{

    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
        
    }
   

}
