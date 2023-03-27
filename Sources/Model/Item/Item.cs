using System;
using NRO_Server.Model.ModelBase;

namespace NRO_Server.Model.Item
{
    public class Item : ItemBase, IDisposable
    {
        internal int itemId;

        public int IndexUI { get; set; }
        public int SaleCoin { get; set; } = 1;
        public long BuyPotential { get; set; }
        public object Index { get; internal set; }

        public Item() : base()
        {
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}