using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleThread
{
    internal static class ListTools
    {
        public static List<List<T>> SplitListDistinct<T>(this List<T> listItems, int nSize = 30)
        {
            var list = new List<List<T>>();
            //var location = listItems.Distinct().ToList();

            for (int i = 0; i < listItems.Count; i += nSize)
            {
                list.Add(listItems.GetRange(i, Math.Min(nSize, listItems.Count - i)));
            }
            return list;
        }

    }
}
