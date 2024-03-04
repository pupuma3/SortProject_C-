using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortProjects.Sort;



namespace SortProjects
{
    class Program
    {


        static void Main(string[] args)
        {

            List<int> beforeArray = new List<int>();

            bool isLoop = true;
            for (int i = 0; i < 10; i++)
            {
                isLoop = true;
                while(isLoop)
                {
                    Random range = new Random();

                    int rand = range.Next(0, 100);

                    if(beforeArray.Count == 0)
                    {
                        beforeArray.Add(rand);
                        isLoop = false;
                        break;
                    }


                    int count = 0;
                    foreach(int index in beforeArray)
                    {
                        if(index == rand)
                        {
                            count++;
                        }
                    }

                    if(count == 0)
                    {
                        isLoop = false;
                        beforeArray.Add(rand);

                        break;
                    }

                    
                }
            }

            Console.WriteLine("Before Array");

            for (int i = 0; i < beforeArray.Count; i++)
            {
                Console.Write(beforeArray[i]);
                Console.Write(" , ");
            }

            Console.WriteLine("");
            Console.WriteLine("================================================================");
            Console.WriteLine("After Sort Array : Selection Sort");
            SelectionSort selectionSort = new SelectionSort();

            List<int> afterSelectionList = selectionSort.Sort<int>(beforeArray);


            for (int i = 0; i < afterSelectionList.Count; i++)
            {
                Console.Write(afterSelectionList[i]);
                Console.Write(" , ");
            }

            Console.WriteLine("");
            Console.WriteLine("================================================================");
            Console.WriteLine("After Sort Array : Insert Sort");

            InsertSort insertSort = new InsertSort();

            List<int> afterInsertList = insertSort.Sort<int>(beforeArray);

            for (int i = 0; i < afterInsertList.Count; i++)
            {
                Console.Write(afterInsertList[i]);
                Console.Write(" , ");
            }

            Console.WriteLine("");
            Console.WriteLine("================================================================");

            Console.WriteLine("After Sort Array : Bubble Sort");

            BubbleSort bubbleSort = new BubbleSort();

            List<int> bubbleList = bubbleSort.Sort<int>(beforeArray);


            for (int i = 0; i < bubbleList.Count; i++)
            {
                Console.Write(bubbleList[i]);
                Console.Write(" , ");
            }

            Console.WriteLine("");

            Console.WriteLine("================================================================");

            Console.WriteLine("After Sort Array : Quick Sort");

            QuickSort quickSort = new QuickSort();

            List<int> quickList = quickSort.Sort<int>(beforeArray);

            for (int i = 0; i < quickList.Count; i++)
            {
                Console.Write(quickList[i]);
                Console.Write(" , ");
            }
            Console.WriteLine("");



            //selectionSort.Sort<>


        }
    }
}
