using System;
using System.Linq;
using Sender.UniOne.ApiClient.Infrastructure;

namespace Sender.UniOne.ApiClient.Common
{
    public class Header : LimitedDictionary<Header>
    {
        private readonly string[] _allowHeaderNames = new[]
            {"List-Unsubscribe", "List-Subscribe", "List-Help", "List-Owner", "List-Archive"};

        protected Header() 
            : base(50)
        {
        }

        public override void Add(string key, string value)
        {
            if (key != null)
            {
                if (!key.StartsWith("X-") && !_allowHeaderNames.Contains(key))
                    throw new ArgumentException("Only headers with “X-” name prefix are accepted or if our support have approved omitting standard unsubscription block for you, you can also pass List-Unsubscribe, List-Subscribe, List-Help, List-Owner and List-Archive");
            }

            base.Add(key, value);
        }
    }
}