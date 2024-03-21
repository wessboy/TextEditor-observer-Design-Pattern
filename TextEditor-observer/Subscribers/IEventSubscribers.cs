using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor_observer.Subscribers
{
    public interface IEventSubscribers
    {
        void Update(string message);
    }
}
