using System;

namespace Observer.Application
{
    public interface IObserver
    {
        void Update<TSubject>(TSubject subject);
    }
}
