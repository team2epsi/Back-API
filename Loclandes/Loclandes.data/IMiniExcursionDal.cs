using System.Collections.Generic;

namespace Loclandes.data
{
    public interface IMiniExcursionDal
    {
        IEnumerable<MiniExcursionDao> GetAllExcursions();

        MiniExcursionDao GetExcursionById(int id);

        void InsertMiniExcursion(MiniExcursionDao miniExcursion);

        int UpdateMiniExcursion(MiniExcursionDao miniExcursion);

        int DeleteMiniExcursion(int idMini);
    }
}
