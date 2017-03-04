using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceTestApp
{
    [Serializable]
    class Source
    {
        //define variables
        public string SerialNo { get; private set; }
        public double DecayConstant { get; private set; }
        public string HigMeg { get; private set; }
        public int BGFlag { get; private set; }

        // construction
        public Source(string serialNo, double decayConstant, string higMeg, int bGFlage)
        {
            SerialNo = serialNo;
            DecayConstant = decayConstant;
            HigMeg = higMeg;
            BGFlag = bGFlage;
        }

        // others
               
        
    }
}
