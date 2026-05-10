using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trickcal.Shared
{
    public abstract class BaseTableItem
    {
        
        private static readonly ConcurrentDictionary<Type, List<PropertyItem>> _allPropertyCache = new();
    }
        // Required by BaseTableItem
        public class PropertyItem
        {
            // Add fields/properties if needed; the generated code returns null anyway.
        }
        public abstract class TableItem<T> : BaseTableItem
        {
            protected TableItem() { }

            [MessagePack.IgnoreMember]
            public T Table;
        }

}
