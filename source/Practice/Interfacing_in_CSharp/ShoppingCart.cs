using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacing_in_CSharp
{
    class ShoppingCart : IEnumerable, ICloneable, IDisposable
    {
        public int TotalAmount { get; set; }
        public int ItemCount { get; set; }

        public ArrayList items = new ArrayList();

        public void AddItem(object item)
        {

        }

        public void RemoveItem(object item)
        {

        }

        //IEnumerable
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //ICloneable
        public object Clone()
        {
            var newItem = new ShoppingCart();
            newItem.TotalAmount = this.TotalAmount;
            newItem.ItemCount = this.ItemCount;

            return newItem;
        }

        //IDisposeable
        public void Dispose()
        {
            items.Clear();
        }
    }
}
