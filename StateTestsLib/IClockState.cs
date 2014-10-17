using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTestsLib
{
    interface IClockState
    {
        void PreviousValue();
        void NextValue();
        void SelectValue();
        int SelectedValue { get; }
    }
}
