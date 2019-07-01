using System;
using System.Collections.Generic;
using System.Text;

namespace Loclandes.data
{
    public interface IMiniExcursionDal
    {
        IEnumerable<MiniExcursionDao> Get();
    }
}
