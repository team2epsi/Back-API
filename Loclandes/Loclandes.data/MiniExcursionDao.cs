using System;
using System.Collections.Generic;
using System.Text;

namespace Loclandes.data
{
    public class MiniExcursionDao
    {
        public int idMiniExcursion {
            
            get => idMiniExcursion;
            set
            {
                if (idMiniExcursion == 0)
                {
                    throw new ArgumentException("L'identifiant ne peut être null");
                }
                idMiniExcursion = value; // set n'a jamais de return
            }
        }
        public string libelleMiniExcursion
        {
            get => libelleMiniExcursion;
            set
            {
                if (libelleMiniExcursion.Length == 0)
                {
                    throw new ArgumentException("L'identifiant ne peut être null");
                }
                libelleMiniExcursion = value; // set n'a jamais de return
            }
        }
        public int nombrePlaceMiniExcursion { get; set; }

        
    }
}
