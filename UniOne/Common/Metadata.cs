using System;
using Sender.UniOne.ApiClient.Infrastructure;

namespace Sender.UniOne.ApiClient.Common
{
    public class Metadata : LimitedDictionary<Metadata>
    {
        private const int MAX_ENTRY_COUNT = 10;

        internal Metadata()
            : base(MAX_ENTRY_COUNT)
        {
        }

        public override void Add(string key, string value)
        {
            if (key.Length > 64)
                throw new ArgumentException("Max key length: 64 symbols");
            if (value?.Length > 1024)
                throw new ArgumentException("Max value length: 1024 symbols");

            base.Add(key, value);
        }
    }
}