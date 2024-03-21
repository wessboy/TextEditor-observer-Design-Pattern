using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor_observer.Subscribers
{
    public class SmsService : IEventSubscribers
    {
        public void Update(string message)
        {
            Console.WriteLine($"Sms:{message}");
        }
    }
}
