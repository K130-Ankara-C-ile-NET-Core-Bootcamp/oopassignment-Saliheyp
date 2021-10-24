using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public interface IObserver<T>
    {
        List<T> GetObservables();
        void Update(T provider);
    }
}
