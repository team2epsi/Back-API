using System.Collections.Generic;

namespace Loclandes.data
{
    public interface IMiniExcursionDal
    {
        IEnumerable<MiniExcursionDao> GetAllMiniExcursions();

        IEnumerable<MiniExcursionDao> GetMiniExcursionById(int id);

        void AddMiniExcursion(MiniExcursionDao mini);

        void DeleteMiniExcursion(int idMini);
    }
}
