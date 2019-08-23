using System;
using System.Collections.Generic;
using System.Text;

namespace MiniExcursion_Data
{
    public interface IMiniExcursionProvider
    {
        IEnumerable<MiniExcursion> Get();
    }
}
