using System;
using System.Collections.Generic;
using System.Text;

namespace Loclandes.data
{
    public interface IMiniExcursionDal
    {
        IEnumerable<MiniExcursionDao> GetAllExcursions();

        MiniExcursionDao GetExcursionById(int id);

        void InsertMiniExcursion(MiniExcursionDao miniExcursion);

        void UpdateMiniExcursion(MiniExcursionDao miniExcursion);

        void DeleteMiniExcursion(int idMini);
    }
}
