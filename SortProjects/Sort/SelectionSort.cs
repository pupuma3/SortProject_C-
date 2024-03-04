using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProjects.Sort
{
    class SelectionSort
    {

        public List<T> Sort<T>(List<T> _list, bool _order = true) where T : IComparable<T>
        {

            List<T> list = _list.ToList();
            int indexMin;
            T temp;

            for (int i = 0; i < list.Count; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    // if ( _order ? _list[j] < _list[indexMin] : _list[j] > _list[indexMin] ) 
                    if (_order ? Comparer<T>.Default.Compare(list[j], list[indexMin]) < 0
                                : Comparer<T>.Default.Compare(list[j], list[indexMin]) > 0)
                    {
                        indexMin = j;
                    }
                }

                temp = list[indexMin];
                list[indexMin] = _list[i];
                list[i] = temp;
            }

            return list;
        }

    }
}
