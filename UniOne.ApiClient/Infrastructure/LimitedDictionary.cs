using System;
using System.Collections.Generic;

namespace Sender.UniOne.ApiClient.Infrastructure
{
    public class LimitedDictionary<T> : Dictionary<string, string>, IDictionarySource
    {
        private readonly int _maxCount;

        protected LimitedDictionary(int maxCount)
            : base(maxCount)
        {
            _maxCount = maxCount;
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

        public void AddRange(Dictionary<string, string> properties)
        {
            foreach (var property in properties)
            {
                Add(property.Key, property.Value);
            }
        }

        public void RemoveIfExist(string key)
        {
            if (ContainsKey(key))
            {
                Remove(key);
            }
        }

        public virtual bool TryAdd(string key, string value)
        {
            try
            {
                Add(key, value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
