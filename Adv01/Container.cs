using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv01
{
    internal class Container<T>
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item) => _items.Add(item);
        public T Get(int index) => _items[index];
    }
}
