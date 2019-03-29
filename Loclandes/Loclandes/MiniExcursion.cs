using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loclandes
{
    public class MiniExcursion
    {
        public int numMiniExcursion { get; private set; }
        public string libelleMiniExcursion { get; private set; }
        public int nombresPlaces { get; private set; }
        //private ICollection<Etape> lesEtapes;

        public MiniExcursion(int idMiniExcursion, string nomMiniExcursion, int nbrePlaces)
        {
            numMiniExcursion = idMiniExcursion;
            libelleMiniExcursion = nomMiniExcursion;
            nombresPlaces = nbrePlaces;
        }


        public int getNombrePlaces()
        {
            return nombresPlaces;
        }


        
    

        // TODO
        //public int donneDureePrevue()
        //{
        //    return;
        //    }

        //public string donneDureePrevuehhmm()
        //    {
        //        return;
        //    }

    
        //public bool ajouteEtape(int inNumEtape, string )
        //{

        //}




    }
}
