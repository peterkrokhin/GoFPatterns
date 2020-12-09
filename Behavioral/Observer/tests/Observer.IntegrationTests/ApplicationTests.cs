using NUnit.Framework;
using Observer.Application;

namespace Observer.IntegrationTests
{
    public class ApplicationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPullStateToAttachedObserver()
        {
            Subject<State> subject = new Subject<State>();
            Observer<State> observer1 = new Observer<State>();

            subject.Attach(observer1);

            subject.SetState(new State("new state"));

            Assert.That(subject.GetState().Equals(observer1.GetState()));
 
        }

        [Test]
        public void TestPullStateToDetachedObserver()
        {
            Subject<State> subject = new Subject<State>();
            Observer<State> observer1 = new Observer<State>();

            subject.Attach(observer1);
            subject.Detach(observer1);

            subject.SetState(new State("new state"));

            Assert.That(!subject.GetState().Equals(observer1.GetState()));
 
        }

        [Test]
        public void TestPullStateToTwoAttachedObservers()
        {
            Subject<State> subject = new Subject<State>();
            Observer<State> observer1 = new Observer<State>();
            Observer<State> observer2 = new Observer<State>();

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.SetState(new State("new state"));

            Assert.That(subject.GetState().Equals(observer1.GetState()) & subject.GetState().Equals(observer2.GetState()));
 
        }
    }
}