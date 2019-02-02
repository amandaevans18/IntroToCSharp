using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToCSharp
{
    class Program
    {
        public enum logicTag
        {
            greeting,
            smallTalk,
            moreSmallTalk,
            deepCOnvo,
            goodbye
        }
        public bool enteredChat = true;
        static void Main(string[] args)
        {
            string input ="";
            Program myProgram = new Program();
            Response response = new Response();
            User newUser = new User();
             

            Console.WriteLine("Please enter your User Name");
            newUser.userName = Console.ReadLine();
            logicTag myTag = logicTag.greeting;


            //while (myProgram.enteredChat)
            //{
            //    ChatLogic.responseCycle(input, response, newUser,myTag);
            //}
            
        }
        }

      
    }

}
