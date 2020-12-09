using System;
using System.Collections.Generic;

namespace Observer.Application
{
    public class Subject<T> : ISubject
    {
        private ICollection<IObserver> Observers { get; set; } = new List<IObserver>();
        private T SubjectState { get; set; }
        public void SetState(T subjectState)
        {
            SubjectState = subjectState;
            Notify();
        }
        public T GetState() => SubjectState;
        public void Attach(IObserver observer) => Observers.Add(observer);
        public void Detach(IObserver observer) => Observers.Remove(observer);

        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(this);
            }
        } 
    }
}
