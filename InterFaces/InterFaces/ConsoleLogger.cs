using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message, int severity)
        {

        }

        public void Assert(bool condition, string message, int severity)
        {

        }

        public int SeverityMin
        {
            get {
                return SeverityMin;
            }
            set {
                SeverityMin = value;
            }
        }
    }
}
