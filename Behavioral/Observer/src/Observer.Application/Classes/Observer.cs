using System;

namespace Observer.Application
{
    public class Observer<T> : IObserver
    {
        private T ObserverState { get; set; }
        //public Observer(T observerState) => ObserverState = observerState;
        public void Update<TSubject>(TSubject subject)
        {
            if (subject is Subject<T> _subject)
                ObserverState = _subject.GetState();
        }
        public T GetState() => ObserverState;
    }
}
