using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTestsLib
{
    class DayState : IClockState
    {
        private ClockSetup setup;
        private int day;

        public DayState(ClockSetup setup, int p)
        {
            // TODO: Complete member initialization
            this.setup = setup;
            day = p;
        }

        public void PreviousValue()
        {
            if (day > 1)
            {
                day--;
            }
        }

        public void NextValue()
        {
            if (day < 31)
            {
                day++;
            }
        }

        public void SelectValue()
        {
            
        }

        public int SelectedValue
        {
            get { return day; }
        }
    }
}
