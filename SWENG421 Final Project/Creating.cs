using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class Creating : ABSOrderState
    {
        public override void handle(Facade mainForm)
        {
            mainForm.SwitchToForm(new CreatingFrame());
        }
    }
}
