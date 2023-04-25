using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4.Observer
{
    public class CObject
    {
        public List<CObserver> _observers = new List<CObserver>();

        protected string Name;
        virtual public String Who()
        {
            return Name;
        }

        virtual public void AddObserver(CObserver o)
        {
            _observers.Add(o);
        }
        virtual public void RemoveObserver()
        {
            _observers.Clear();
        }

        virtual public void NotifyEveryone()
        {
            foreach (CObserver o in _observers)
            {
                o.OnSubjectChanged(this);
            }
        }

        virtual public void NotifyEveryoneSelect()
        {
            foreach (CObserver o in _observers)
            {
                o.OnSubjectSelect(this);
            }
        }

        virtual public void NotifyEveryoneMove(int x, int y)
        {
            foreach (CObserver o in _observers)
            {
                o.OnSubjectMove(x, y);
            }
        }


        public virtual void Dispose()
        {
        }
    }
}
