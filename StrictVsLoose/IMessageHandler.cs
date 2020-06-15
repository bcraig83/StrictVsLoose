using System.Collections.Generic;

namespace StrictVsLoose
{
    public interface IMessageHandler
    {
        public bool HandleMessage(string message);
        public IList<string> GetMessages();
        public void SendToParser();
    }
}