using System.Collections.Generic;

namespace StrictVsLoose
{
    public interface IMessageProcessor
    {
        public bool ProcessMessages(IList<string> messages);
        public IList<string> GetMessages();
    }
}