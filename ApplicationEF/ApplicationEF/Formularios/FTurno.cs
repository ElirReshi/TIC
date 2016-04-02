using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationEF.Formularios
{
    public partial class FTurno : Form
    {
        public FTurno()
        {
            InitializeComponent();
        }

        private void tab1mtbHoraE_Click(object sender, EventArgs e)
        {
            tab1mtbHoraE.Select(0, 0);
        }

        private void tab1mtbHoraS_Click(object sender, EventArgs e)
        {
            tab1mtbHoraS.Select(0, 0);
        }

        private void tab2mtbHoraE_Click(object sender, EventArgs e)
        {
            tab2mtbHoraE.Select(0, 0);
        }

        private void tab2mtbHoraS_Click(object sender, EventArgs e)
        {
            tab2mtbHoraS.Select(0, 0);
        }
    }
}
