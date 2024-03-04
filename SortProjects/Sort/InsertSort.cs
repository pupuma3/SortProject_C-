using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProjects.Sort
{
    class InsertSort
    {

        public bool CompareTo<T>(bool _order, T _first, T _second) where T : IComparable<T>
        {
            //return  ( _order ? _list[j] > _list[indexMin] : _list[j] < _list[indexMin] ) 
            return _order ? Comparer<T>.Default.Compare(_first, _second) > 0
                            : Comparer<T>.Default.Compare(_first, _second) < 0;
        }


        public List<T> Sort<T>(List<T> _list, bool _order = true) where T : IComparable<T>
        {
            List<T> list = _list.ToList();


            for (int i = 1; i < list.Count; i++)
            {
                T temp = list[i];

                int aux = i - 1;

                while ((aux >= 0) && CompareTo<T>(_order, list[aux], temp))
                {
                    
                    list[aux + 1] = list[aux];
                    aux--;

                

                }

                list[aux + 1] = temp;

            }

            return list;
        }


    }
}
