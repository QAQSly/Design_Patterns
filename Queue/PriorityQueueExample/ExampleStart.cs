using PriorityQueue;
using System.Collections;
using System;
namespace PriorityQueueExample;

public class Item: IComparable<Item>
{
    public string ItemName;
    public float Priority;

    public int CompareTo(Item other)
    {

        if (Priority < other.Priority)
        {
            return -1;
        }
        else if (Priority > other.Priority)
                
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{ItemName} {Priority}");
    }
}

class ExampleStart
{
    static void Main(string[] args)
    {
        int count = 10000;
        while (count > 0)
        {
            count--;
            LoopTest();
        }
    }

    static void LoopTest()
    {
       Random r = new Random();
       int itemCount = r.Next(100, 9999);
       List<Item> itemList = new List<Item>(itemCount);
       for (int i = 0; i < itemCount; i++)
       {
           itemList.Add(new Item {
                   ItemName = $"item{i}",
                   Priority = r.Next(0, 10000)});
       }

       PriorityQueue<Item> pqueue = new PriorityQueue<Item>();
       for (int i = 0; i < itemList.Count; i++)
       {
           pqueue.Enqueue(itemList[i]);
       }

       int removeCount = r.Next(0, 9999);
       for (int i = 0; i < removeCount; i++)
       {
           int index = r.Next(0, pqueue.Count);
           int pqueueIndex = pqueue.IndexOf(itemList[index]);
           if (pqueueIndex >= 0)
           {
               pqueue.RemoveAt(pqueueIndex);
           }
       }

       List<Item> outList = new List<Item>();
       while (pqueue.Count > 0)
       {
           Item item = pqueue.Dequeue();
           outList.Add(item);
           
           item.PrintInfo();
       }

       for (int i = 0; i < outList.Count; i++)
       {
           if (i < outList.Count - 1)
           {
               if (outList[i].Priority > outList[i + 1].Priority)
               {
                   Exception e = new Exception("优先级异常");
                   throw e;
               }
           }
       }

    }

}
