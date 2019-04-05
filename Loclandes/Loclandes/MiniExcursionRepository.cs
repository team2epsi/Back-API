using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loclandes
{
    public class MiniExcursionRepository
    {

        private List<MiniExcursion> _miniExcursions = new List<MiniExcursion>()
        {
          new MiniExcursion(1,"visite de la Cite du Vin",4),
          new MiniExcursion( 2, "balade à Bordeaux", 8),
          new MiniExcursion( 3, "sortie à Arcachan", 5),
          new MiniExcursion( 4, "Découverte de Cdiscount avec L'equipe 2", 15)
        };

    public List<MiniExcursion> getAllExcursion()
        {
            return _miniExcursions;
        }

    


    }
}
