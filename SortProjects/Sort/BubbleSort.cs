using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProjects.Sort
{
    class BubbleSort
    {
        public List<T> Sort<T>(List<T> _list, bool _order = true) where T : IComparable<T>
        {
            List<T> list = _list.ToList();
            T temp;

            for (int i = list.Count -1; i > 0 ; i--)
            {
                for(int j = 0; j  < i; j++)
                {
                    if (_order ? Comparer<T>.Default.Compare(list[j], list[j + 1]) > 0
                               : Comparer<T>.Default.Compare(list[j], list[j + 1]) < 0)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;

                    }
                }
            }

            return list;

        }
    }
}
