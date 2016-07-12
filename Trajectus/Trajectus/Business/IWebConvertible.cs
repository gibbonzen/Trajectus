using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajectus.Business
{
    public interface IWebConvertible<T, U>
    {
        T Convert<T, U>(U WebModel);
    }
}
