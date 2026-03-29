using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv01
{
    internal class Pair<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Val { get; set; }

        public Pair(TKey first, TValue second)
        {
            Key = first;
            Val = second;
        }

    }
}
