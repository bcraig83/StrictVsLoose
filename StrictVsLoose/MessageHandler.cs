using System.Collections.Generic;
using System.Text;

namespace StrictVsLoose
{
    public class MessageHandler : IMessageHandler
    {
        private readonly IList<string> _messages;

        public MessageHandler()
        {
            _messages = new List<string>();
        }

        public IList<string> GetMessages()
        {
            return _messages;
        }

        public bool HandleMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return false;
            }

            var sb = new StringBuilder();
            sb.Append($"[The message is: {message}]");

            _messages.Add(sb.ToString());
            return true;
        }
    }
}