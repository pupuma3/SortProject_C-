using System;
using System.Collections.Generic;
using System.Linq;

namespace SortProjects.Sort
{
    class QuickSort
    {

        private void Swap<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        private int Partition<T>(List<T> list, int low, int high) where T : IComparable<T>
        {


            T pivot = list[high];  

            int i = low - 1; 

            for (int j = low; j < high; j++)
            {
                if (list[j].CompareTo(pivot) <= 0) 
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);

            return i + 1;
        }

        private void QuickSortTo<T>(List<T> _list , int left , int right) where T : IComparable<T>
        {

            if (left < right)
            {
                // 3 9 4  7  5 0 1 8 6 2   

                int partitionIndex = Partition(_list, left, right);

                QuickSortTo(_list, left, partitionIndex - 1);
                QuickSortTo(_list, partitionIndex + 1, right);
            }
        }



        public List<T> Sort<T>(List<T> _list, bool order = true) where T : IComparable<T>
        {
            List<T> list = _list.ToList();

            QuickSortTo(list, 0, list.Count - 1);

            if (!order)
            {
                list.Reverse();
            }

            return list;
        }
    }
}
