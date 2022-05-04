using System;
using System.Collections.Generic;

namespace Sender.UniOne.ApiClient.Infrastructure
{
    public class LimitedDictionary<T> : Dictionary<string, string> 
    {
        private readonly int _maxCount;

        protected LimitedDictionary(int maxCount)
            : base(maxCount)
        {
            _maxCount = maxCount;
        }

        public static T Instance()
        {
            return (T)Activator.CreateInstance(typeof(T), true);
        }

        public new virtual void Add(string key, string value)
        {
            if (Count == _maxCount)
                throw new ArgumentOutOfRangeException($"Max key quantity = {_maxCount}");
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("Key is required");
            if (ContainsKey(key))
                throw new ArgumentException("Key already exist");

            base.Add(key, value);
        }

        public void RemoveIfExist(string key)
        {
            if (ContainsKey(key))
            {
                Remove(key);
            }
        }
    }
}