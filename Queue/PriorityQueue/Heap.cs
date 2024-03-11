using System;
using System.Collections.Generic;


namespace PriorityQueue
{
    public class Heap
    {
        public List<int> list = null;

        public Heap(int capacity = 4)
        {
            list = new List<int>(capacity);
        }

        public void AddNode(int value)
        {
            list.Add(value);
            StackingUp();
        }

        public void StackingUp()
        {
            int childIndex = list.Count - 1;
            int parentIndex = (childIndex - 1) / 2;
            while (childIndex > 0 && list[childIndex] < list[parentIndex])
            {
                Swap(childIndex, parentIndex);
                childIndex = parentIndex;
                parentIndex = (childIndex - 1) / 2;
            }
        }

        public int RemoveNode()
        {
            if (list.Count == 0)
            {
                return int.MinValue;
            }
            int value = list[0];
            
            int endIndex = list.Count - 1;
            list[0] = list[endIndex];

            list.RemoveAt(endIndex);
            --endIndex;

            StackingDown(endIndex);

            return value;


        }

        public void StackingDown(int endIndex)
        {
            int topIndex = 0;
            while (true)
            {
                int minIndex = topIndex;

                int childIndex = topIndex * 2 + 1;
                // left
                if (childIndex <= endIndex && list[childIndex] < list[topIndex])
                {
                    minIndex = childIndex;
                }

                childIndex = topIndex * 2 + 2;

                // right
                if (childIndex <= endIndex && list[childIndex] < list[minIndex])
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

        void Swap(int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        
    }
}
