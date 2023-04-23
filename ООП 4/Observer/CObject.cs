using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4.Observer
{
    public class CObject
    {
        private List<CObserver> _observers = new List<CObserver>();

        protected string Name;
        virtual public String Who()
        {
            return Name;
        }

        public void AddObserver(CObserver o)
        {
            _observers.Add(o);
        }
        public void RemoveObserver(CObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyEveryone()
        {
            foreach (CObserver o in _observers)
            {
                o.OnSubjectChanged(this);
            }
        }

        public void NotifyEveryoneSelect()
        {
            foreach (CObserver o in _observers)
            {
                o.OnSubjectSelect(this);
            }
        }

        public virtual void Dispose()
        {
        }
    }
}
