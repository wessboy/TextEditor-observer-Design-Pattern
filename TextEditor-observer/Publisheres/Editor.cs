using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor_observer.Publisheres
{
    public class Editor
    {
        public EventManager _events;
        public Editor()
        {
            _events = new EventManager();
            
        }
        public void OpenFile()
        {
            _events.Notify("File Opened !!");

        }

        public void CloseFile() {

            _events.Notify("File Closed !!");
        
        }
    }
}
