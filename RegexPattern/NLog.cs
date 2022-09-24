using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace RegexPattern
{
    public class NLog
    {
    public static readonly Logger logger=LogManager.GetCurrentClassLogger();

        public void LogDebug(string msg)
        {
            logger.Debug(msg);
        }
        public void LogError(string msg)
        {
            logger.Error(msg);
        }
    }
}
