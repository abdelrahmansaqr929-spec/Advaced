using System;
using System.Collections.Generic;
using System.Text;

namespace Abvanced
{
    public class Cache<TKey, TValue>
    {
        private class Item
        {
            public TKey Key;
            public TValue Value;
            public DateTime? ExpiresAt;
        }

        private List<Item> _items = new();

        public void Add(TKey key, TValue value, int seconds = 0)
        {
            Remove(key);   // replace if the key already exists

            _items.Add(new Item
            {
                Key = key,
                Value = value,
                ExpiresAt = seconds > 0 ? DateTime.Now.AddSeconds(seconds) : null
            });
        }

        public bool Contains(TKey key)
        {
            RemoveExpired();
            return _items.Any(i => Equals(i.Key, key));
        }

        public TValue Get(TKey key)
        {
            RemoveExpired();

            var item = _items.FirstOrDefault(i => Equals(i.Key, key));
            if (item == null)
                throw new KeyNotFoundException("Key not found or expired.");

            return item.Value;
        }

        public void Remove(TKey key)
        {
            _items.RemoveAll(i => Equals(i.Key, key));
        }

        private void RemoveExpired()
        {
            _items.RemoveAll(i => i.ExpiresAt != null && DateTime.Now > i.ExpiresAt);
        }
    }
}
