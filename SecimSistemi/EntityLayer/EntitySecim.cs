using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySecim
    {
        private string ilceAd;
        private short aTEKNO;
        private short bTEKNO;
        private short cTEKNO;
        private short dTEKNO;
        private short eTEKNO;

        public string ILCEAD { get => ilceAd; set => ilceAd = value; }
        public short ATEKNO { get => aTEKNO; set => aTEKNO = value; }
        public short BTEKNO { get => bTEKNO; set => bTEKNO = value; }
        public short CTEKNO { get => cTEKNO; set => cTEKNO = value; }
        public short DTEKNO { get => dTEKNO; set => dTEKNO = value; }
        public short ETEKNO { get => eTEKNO; set => eTEKNO = value; }
    }
}
