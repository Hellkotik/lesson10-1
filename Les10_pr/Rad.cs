using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les10_pr
{
    class Rad
    {
        int gradG;
        int gradM;
        int gradS;
        public int GradG
        {
            get
            {
                return gradG;
            }

            set
            {
                //углы могут быть отрицательными и большими
               gradG = value;
                
            }

        }
        public int GradM
        {
            get
            {
                return gradM;
            }

            set
            {
                GradG += value / 60;
                gradM = value % 60;
              
            }

        }
        public int GradS
        {
            get
            {
                return gradS;
            }

            set
            {
                GradM += value / 60;
                gradS = value % 60;
            }

        }
        

        public Rad(int gradG, int gradM, int gradS)
        {
            this.GradG = gradG;
            this.GradM = gradM;
            this.GradS = gradS;
        }
        public double ToRad()
        {
            return (gradS/3600+gradM/60+gradG);
        }

    }
}
