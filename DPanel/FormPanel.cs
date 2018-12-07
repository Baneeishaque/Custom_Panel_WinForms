using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPanel
{
    class FormPanel : Panel 
    {
        bool previous; 
        FormPanel l;

        public FormPanel() 
        {
            previous = false; 
            l.Parent = this; 
            l.Dock = DockStyle.Fill;
            
        } 
    }
}
