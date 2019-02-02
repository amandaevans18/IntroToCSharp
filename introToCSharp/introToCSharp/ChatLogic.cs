using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static introToCSharp.Program;

namespace introToCSharp
{
    class ChatLogic
    {
        public string[] badWords = { "ray", "gay" };
        public static void responseCycle(string userInput, Response whatToRespond, User currentUser, logicTag tag)
        {


            switch (tag)
            {
                case logicTag.greeting:

                    break;
                case logicTag.smallTalk:
                    break;
                case logicTag.moreSmallTalk:
                    break;
                case logicTag.deepCOnvo:
                    break;
                case logicTag.goodbye:
                    break;

            }

        }

        public static string chatCleanUp(string userInput)
        {
            ChatLogic chatLogic = new ChatLogic();
            string cleanSentence ="";
            string asterisk = "";
            userInput = userInput.ToLower();
            int index = new int;
            index = chatLogic.badWords.Length;

            while (index != -1)
            {
                for (int i = 0; i < chatLogic.badWords.Length; i++)
                {
                    if (userInput.Contains(chatLogic.badWords[i]))
                    {
                        for (int x = 0; x < chatLogic.badWords[i].Length; x++)
                        {
                            asterisk += "*";
                        }
                        userInput.Replace(chatLogic.badWords[i], asterisk);
                        
                    }
                }
                index--;
            }




            return cleanSentence;
        }
    }
}
