using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 主题
    /// </summary>
   abstract class Subject
    {
       private ArrayList observers = new ArrayList();
       public void Attach(Observer observer)
       {
           observers.Add(observer);
       }
       public void Detach(Observer observer)
       {
           observers.Remove(observer);
       }
       public void Notify()
       {
           foreach (Observer o in observers)
           {
               o.Update();
           }
       }
    }
   class ConcreSubject:Subject
   {
       private string subjectState;
       public string SubjectState
       {
           get { return subjectState; }
           set { subjectState = value; }
       }
   }
    /// <summary>
    /// 观察者
    /// </summary>
   abstract class Observer
    {
       public abstract void Update();
    }
   class ConcreteObserver : Observer
   {
       private string name;
       private string observerState;
       private ConcreSubject subject;
       public ConcreteObserver(ConcreSubject subject, string name)
       {
           this.subject = subject;
           this.name = name;
       }


       public override void Update()
       {
           observerState = subject.SubjectState;
           Console.WriteLine("Observer {0}'s new state is {1}",
           name, observerState);
       }
       public ConcreSubject Subject
       {
           get { return subject; }
           set { subject = value; }
       }
   }
}
