using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTestsLib
{
    class YearState : IClockState
    {
        private ClockSetup setup;
        private int year;

        public YearState(ClockSetup setup, int p)
        {
            // TODO: Complete member initialization
            this.setup = setup;
            year = p;
        }

        public void PreviousValue()
        {
            year--;
        }

        public void NextValue()
        {
            year++;
        }

        public void SelectValue()
        {
            setup.State = setup.MonthState;
        }

        public int SelectedValue
        {
            get { return year; }
        }
    }
}
