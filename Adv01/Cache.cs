using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adv01
{
    // Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 

    internal class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public CacheItem(TValue value, DateTime expirationTime)
            {
                Value = value;
                ExpirationTime = expirationTime;
            }

            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
            public bool IsExpired => DateTime.Now > ExpirationTime;
        }
        
        private readonly Dictionary<TKey, CacheItem> _items = new();
        
        public void Add(TKey key, TValue value, TimeSpan expiration)
              =>_items[key] = new CacheItem(value, DateTime.Now.Add(expiration));

        public bool Contains(TKey key)  =>_items.ContainsKey(key) && !_items[key].IsExpired;
         
        public TValue Get(TKey key) => Contains(key) ? _items[key].Value : default;

        public void Remove(TKey key)=> _items.Remove(key);
        
        
        
    }
}
