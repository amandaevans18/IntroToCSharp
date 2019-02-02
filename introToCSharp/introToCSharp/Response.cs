using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToCSharp
{
    class Response
    {
        public string aiGreeting(string userName)
        {
            return "Hello " +userName;
        }
        public string smallTalk(string userName, string lastResponse)
        {
            return "";
        }
    }
}
