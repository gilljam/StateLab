using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTestsLib
{
    class ClockSetup
    {
        DateTime selectedDate;
        public IClockState State { get; set; }
        public YearState YearState { get; set; }

        public MonthState MonthState { get; set; }

        public DayState DayState { get; set; }


        internal void PushKnob()
        {
            if (State == null)
                State = YearState;
            else
                State.SelectValue();
        }

        internal void RotateRight()
        {
            State.NextValue();
        }

        internal void RotateLeft()
        {
            State.PreviousValue();
        }

        internal DateTime GetSelectedDate()
        {
            selectedDate = new DateTime(YearState.SelectedValue, MonthState.SelectedValue, DayState.SelectedValue, 0, 0, 0);
            return selectedDate;
        }
    }
}
