using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    class Clock
    {
        int hour;
        int min;
        int sec;

        public int Hour
        { get
            {
                return hour;
            }

           set
            {
                hour = value % 24;
            }
        
        }

        public int Min
        {
            get
            {
                return min;
            }

            set
            {
                Hour += value / 60;
                min = value%60;
                
            }

        }

        public int Sec
        {
            get
            {
                return sec;
            }


            set
            {
                Min += value / 60;
                sec = value % 60;
                
            }

        }


        public Clock (int hour, int min, int sec)
        {
            this.Hour = hour;
            this.Min = min;
            this.Sec = sec;
        }
        public int ToSecond()
        {
            return sec + min * 60 + hour * 60 * 60;
        }
    }
}
