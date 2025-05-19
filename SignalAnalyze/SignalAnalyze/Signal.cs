using System;
using System.Runtime.CompilerServices;
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

        public bool ContainsWord(string _word)
        {
            string clenMsg = GetCleanMessage();
            string lowerWord = _word.ToLower();
            string[] words = clenMsg.Split(' ');
            foreach (string word in words)
            {
                if (word == lowerWord)
                {
                    return true;
                }
            }
            return false;
        }

        public DateTime GetTimeStamp()
        {
            return timeStamp;
        }

        public override string ToString()
        {
            return $"raw message: {this.rawMessage}, timestamp: {this.timeStamp}";
        }

    }
}
