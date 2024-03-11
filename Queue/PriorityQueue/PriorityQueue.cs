using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T: IComparable<T>
    {
        public int Count
        {
            get => list.Count;
        }
        public List<T> list = null;

        public PriorityQueue(int capacity = 4)
        {
            list = new List<T>(capacity);
        }

        public void Enqueue(T item)
        {
            list.Add(item);
            int childIndex = list.Count - 1;
            int parentIndex = (childIndex - 1) / 2;
            StackingUp(childIndex, parentIndex);
        }

        public void StackingUp(int childIndex, int parentIndex)
        {
            while (childIndex > 0 && list[childIndex].CompareTo(list[parentIndex]) < 0)
            {
                Swap(childIndex, parentIndex);
                childIndex = parentIndex;
                parentIndex = (childIndex - 1) / 2;
            }
        }

        public T Dequeue()
        {
            if (list.Count == 0)
            {
                return default;
            }
            T item = list[0];
            
            int endIndex = list.Count - 1;
            list[0] = list[endIndex];

            list.RemoveAt(endIndex);
            --endIndex;
            int topIndex = 0;

            StackingDown(topIndex, endIndex);

            return item;


        }

        public void StackingDown(int topIndex, int endIndex)
        {
            while (true)
            {
                int minIndex = topIndex;

                int childIndex = topIndex * 2 + 1;
                // left
                if (childIndex <= endIndex && list[childIndex].CompareTo(list[topIndex]) < 0)
                {
                    minIndex = childIndex;
                }

                childIndex = topIndex * 2 + 2;

                // right
                if (childIndex <= endIndex && list[childIndex].CompareTo(list[minIndex]) < 0)
                {
                    minIndex = childIndex;
                }

                if (minIndex == topIndex)
                {
                    break;
                }

                Swap(topIndex, minIndex);
                topIndex = minIndex;
            }

        }

        public void Print()
        {
            list.ForEach(item => {
                    Console.WriteLine(item);
                    });
        }

        public T Peek()
        {
            return list.Count > 0 ? list[0] : default;
        }

        public void Clear()
        {
            list.Clear();
        }

        public int IndexOf(T t)
        {
            return list.IndexOf(t);
        }

        public T RemoveItem(T t)
        {
            int index = IndexOf(t);
            return index != -1 ? RemoveAt(index) : default;
        }

        public T RemoveAt(int index)
        {
            if (list.Count < index)
            {
                return default;
            }


            T item = list[index];
            int endIndex = list.Count - 1;
            list[index] = list[endIndex];
            list.RemoveAt(endIndex);
            --endIndex;
            if (index < endIndex)
            {
                int parentIndex = (index - 1) / 2;
                if (parentIndex > 0 && list[index].CompareTo(list[parentIndex]) < 0)
                {
                    StackingUp(index, parentIndex);
                }
                else 
                {
                    StackingDown(index, endIndex);
                }

            }
            return item;

        }

        public bool Contains(T t)
        {
            return list.Contains(t);
        }

        public bool isEmpty()
        {
            return list.Count == 0;
        }

        public List<T> ToList()
        {
            return list;
        }

        public T[] ToArray()
        {
            return list.ToArray();
        }

        void Swap(int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

    }
}
