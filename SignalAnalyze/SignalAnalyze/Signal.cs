using System;
using System.Text;

namespace SignalAnalyze
{
    internal class Signal
    {
        private string rawMessage;
        private DateTime timeStamp;

        public Signal(string rawMessage)
        {
            this.rawMessage = rawMessage;
            this.timeStamp = DateTime.Now;
        }

        public string GetCleanMessage()
        {
            string editedMsg = "";
            string lowerMsg = rawMessage.ToLower();
            for (int i = 0; i < lowerMsg.Length; i++)
            {
                char c = lowerMsg[i];
                if ((c >= 'a' && c <= 'z') || c == ' ')
                {
                    editedMsg += c;
                }
            }
            return editedMsg;
        }




      
    }
}
