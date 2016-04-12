using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationEF.Diagrama;

namespace ApplicationEF.Formularios
{
    public partial class FTurno : Form
    {
        #region Variables
        private int punto;
        private DataGridViewRow dgv;
        #endregion
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
        private void actualizar()
        {
            using (var db = new TICEntities1())
            {
                Grid.DataSource = db.list_turno.ToList();
            }
        }
        private void FTurno_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void tab1btAgregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tab1tbCod.Text + " - " + tab1tbTurno.Text + " - " + tab1mtbHoraE.Text + " - " + tab1mtbHoraS.Text);
            if (string.IsNullOrEmpty(tab1tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (string.IsNullOrEmpty(tab1tbTurno.Text))
            {
                MessageBox.Show("El turno está vacio");
            }
            else if (!(tab1mtbHoraE.MaskFull))
            {
                MessageBox.Show("Horario de Entrada está vacio");
            }
            else if (!(tab1mtbHoraS.MaskFull))
            {
                MessageBox.Show("Horario de Salida está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.insert_turno(tab1tbCod.Text, tab1tbTurno.Text, TimeSpan.Parse(tab1mtbHoraE.Text), TimeSpan.Parse(tab1mtbHoraS.Text));
                }
                actualizar();
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            punto = e.RowIndex;
            if (punto >= 0)
            {
                dgv = Grid.Rows[punto];
                tab2tbCod.Text = dgv.Cells[0].Value.ToString();
                tab3tbCod.Text = tab2tbCod.Text;
                tab2tbTurno.Text = dgv.Cells[1].Value.ToString();
                tab2mtbHoraE.Text = dgv.Cells[2].Value.ToString();
                tab2mtbHoraS.Text = dgv.Cells[3].Value.ToString();
            }
        }

        private void tab2btModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab2tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (string.IsNullOrEmpty(tab2tbTurno.Text))
            {
                MessageBox.Show("El turno está vacio");
            }
            else if (!(tab2mtbHoraE.MaskFull))
            {
                MessageBox.Show("Horario de Entrada está vacio");
            }
            else if (!(tab2mtbHoraS.MaskFull))
            {
                MessageBox.Show("Horario de Salida está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.modificar_turno(tab2tbCod.Text, tab2tbTurno.Text, TimeSpan.Parse(tab2mtbHoraE.Text), TimeSpan.Parse(tab2mtbHoraS.Text));
                }
                actualizar();
            }
            }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab3tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    var pro = db.Turno.Where(q => q.CodTurno == tab3tbCod.Text).FirstOrDefault();
                    db.Turno.Remove(pro);
                    db.SaveChanges();
                }
                actualizar();
            }
        }
    }
}
