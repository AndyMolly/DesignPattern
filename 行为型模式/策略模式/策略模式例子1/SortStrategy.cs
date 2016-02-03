using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式例子1
{
  abstract  class SortStrategy
    {
      public abstract void Sort(ArrayList list);
    }
  class QuickSort : SortStrategy
  {

      public override void Sort(ArrayList list)
      {
          list.Sort();
          Console.WriteLine("QuickSorted list ");
      }
  }
  class ShellSort : SortStrategy
  {

      public override void Sort(ArrayList list)
      {
          Console.WriteLine("ShellSorted list ");
      }
  }
  class MergeSort : SortStrategy
  {
      public override void Sort(ArrayList list)
      {
          //list.MergeSort(); not-implemented
          Console.WriteLine("MergeSorted list ");
      }
  }
  class SortedList
  {
      private ArrayList list = new ArrayList();
      private SortStrategy sortstrategy;
      public void SetSortStrategy(SortStrategy sortStrategy)
      {
          this.sortstrategy = sortStrategy;
      }
      public void Add(string name)
      {
          list.Add(name);
      }
      public void Sort()
      {
          sortstrategy.Sort(list);

          // Display results
          foreach (string name in list)
          {
              Console.WriteLine(" " + name);
          }
          Console.WriteLine();
      }
  }
}
