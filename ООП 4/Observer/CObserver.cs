using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ООП_4.Observer
{
    public interface CObserver
    {
         void OnSubjectChanged(CObject who);

         void OnSubjectSelect(CObject who);

        void OnSubjectMove(int x, int y);


    }
}
