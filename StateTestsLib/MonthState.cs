using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTestsLib
{
    class MonthState : IClockState
    {
        private ClockSetup setup;
        private int month;

        public MonthState(ClockSetup setup, int p)
        {
            // TODO: Complete member initialization
            this.setup = setup;
            month = p;
        }

        public void PreviousValue()
        {
            if (month > 1)
            {
                month--;
            }
        }

        public void NextValue()
        {
            if (month < 12)
            {
                month++;
            }
        }

        public void SelectValue()
        {
            setup.State = setup.DayState;
        }

        public int SelectedValue
        {
            get { return month; }
        }
    }
}
