using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG421_Final_Project
{
    internal class MainForm
    {
        private Form currentForm = null;
        public void SwitchToForm(Form newForm) 
        {
            if (currentForm != null)
            { 
                currentForm.Close();
            }

            currentForm = newForm;
            currentForm.Show();
        }
    }
}
