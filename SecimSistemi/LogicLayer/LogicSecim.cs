using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicSecim
    {
        public static int LLOyEkle(EntitySecim ent)
        {
            if (ent.ILCEAD!="" && 
                !string.IsNullOrEmpty(ent.ATEKNO.ToString()) && 
                !string.IsNullOrEmpty(ent.BTEKNO.ToString()) && 
                !string.IsNullOrEmpty(ent.CTEKNO.ToString()) && 
                !string.IsNullOrEmpty(ent.DTEKNO.ToString()) && 
                !string.IsNullOrEmpty(ent.ETEKNO.ToString()))
            {
                return DALSecim.OyEkle(ent);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntitySecim> LLIlceCek()
        {
            return DALSecim.IlceGetir();
        }

        public static List<EntitySecim> LLSonuclar()
        {
            return DALSecim.SonucGetir();
        }

    }
}
 