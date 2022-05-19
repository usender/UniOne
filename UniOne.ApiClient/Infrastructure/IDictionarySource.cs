using System.Collections.Generic;

namespace Sender.UniOne.ApiClient.Infrastructure
{
    public interface IDictionarySource
    {
        void Add(string key, string value);
        void AddRange(Dictionary<string, string> data);
    }
}
