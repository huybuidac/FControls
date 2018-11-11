﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace FControls.Form.Extensions
{
    public static class EnumerableExtensions
    {
        public static int Count(this IEnumerable source)
        {
            if (source is ICollection col)
                return col.Count;

            int c = 0;
            var e = source.GetEnumerator();
            DynamicUsing(e, () =>
            {
                while (e.MoveNext())
                    c++;
            });

            return c;
        }
        private static void DynamicUsing(object resource, Action action)
        {
            try
            {
                action();
            }
            finally
            {
                if (resource is IDisposable d)
                    d.Dispose();
            }
        }

        private static int FindIndex(IEnumerable items, Func<dynamic, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            int retVal = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return retVal;
                retVal++;
            }
            return -1;
        }

        public static object Find(this IEnumerable items, Func<dynamic, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            object retVal = null;
            foreach (var item in items)
            {
                if (predicate(item)) break;
                retVal = item;
            }
            return retVal;
        }

        public static int IndexOf(this IEnumerable items, object item)
        {
            if (items is IList)
            {
                return (items as IList).IndexOf(item);
            }
            return FindIndex(items, i => EqualityComparer<object>.Default.Equals(item, i));
        }

        public static object ElementAt(this IEnumerable items, int index)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (index < 0) throw new IndexOutOfRangeException("index");

            if (items is IList)
            {
                return (items as IList)[index];
            }
            object retVal = null;
            var pos = -1;
            foreach (var item in items)
            {
                pos++;
                if (pos == index)
                {
                    retVal = item;
                    break;
                }
                if (pos > index)
                    break;
            }
            if (retVal == null)
                throw new IndexOutOfRangeException("index");
            return retVal;
        }
    }
}
