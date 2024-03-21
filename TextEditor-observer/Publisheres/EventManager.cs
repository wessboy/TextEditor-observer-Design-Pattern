using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor_observer.Subscribers;

namespace TextEditor_observer.Publisheres
{
     public class EventManager
    {
        private List<IEventSubscribers> Subscribers;
       
        public EventManager()
        {
            Subscribers = new List<IEventSubscribers>();
            
        }
        public void Subscribe(IEventSubscribers subscriber)
        {
            Subscribers.Add(subscriber);

        }

        public void Unsubscribe(IEventSubscribers subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void Notify(string message)
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(message);
            }
        }

    }
}
