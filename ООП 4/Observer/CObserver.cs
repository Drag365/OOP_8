using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООП_4.Observer
{
    public abstract class CObserver
    {
        public abstract void OnSubjectChanged(CObject who);

        public abstract void OnSubjectSelect(CObject who);

        public virtual void Dispose()
        {
        }
    }
}
