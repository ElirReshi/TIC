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
    public partial class FDocente : Form
    {
        #region Variables
        private int punto;
        private DataGridViewRow dgv;
        #endregion
        private void actualizar()
        {
            using (var db = new TICEntities1())
            {
                Grid.DataSource = db.list_docente.ToList();
            }
        }
        public FDocente()
        {
            InitializeComponent();
        }

        private void FDocente_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void tab2mtbCedula_Click(object sender, EventArgs e)
        {
            tab2mtbCedula.Select(0, 0);
        }

        private void tab2mtbCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tab2mtbCelular.Select(0, 0);
        }

        private void tab1mtbCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tab1mtbCedula.Select(0, 0);
        }

        private void tab1mtbCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tab1mtbCelular.Select(0, 0);
        }

        private void tab1btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab1tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (!(tab1mtbCedula.MaskFull))
            {
                MessageBox.Show("La cédula está vacia");
            }
            else if (string.IsNullOrEmpty(tab1tbNombre.Text))
            {
                MessageBox.Show("El nombre está vacio");
            }
            else if (string.IsNullOrEmpty(tab1tbApellido.Text))
            {
                MessageBox.Show("El apellido está vacio");
            }
            else if (!(tab1mtbCelular.MaskFull))
            {
                MessageBox.Show("El célular está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.insert_docente(tab1tbCod.Text, tab1mtbCedula.Text, tab1tbNombre.Text, tab1tbApellido.Text, int.Parse(tab1mtbCelular.Text));
                }
                actualizar();
            }
        }

        private void tab2btModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab2tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (!(tab2mtbCedula.MaskFull))
            {
                MessageBox.Show("La cédula está vacia");
            }
            else if (string.IsNullOrEmpty(tab2tbNombre.Text))
            {
                MessageBox.Show("El nombre está vacio");
            }
            else if (string.IsNullOrEmpty(tab2tbApellido.Text))
            {
                MessageBox.Show("El apellido está vacio");
            }
            else if (!(tab2mtbCelular.MaskFull))
            {
                MessageBox.Show("El célular está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.modificar_docente(tab2tbCod.Text, tab2mtbCedula.Text, tab2tbNombre.Text, tab2tbApellido.Text, int.Parse(tab2mtbCelular.Text));
                }
                actualizar();
            }
        }

        private void tab3btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab3tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    var pro = db.Docente.Where(q => q.CodDocente == tab3tbCod.Text).FirstOrDefault();
                    db.Docente.Remove(pro);
                    db.SaveChanges();
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
                tab2mtbCedula.Text = dgv.Cells[1].Value.ToString();
                tab2tbNombre.Text = dgv.Cells[2].Value.ToString();
                tab2tbApellido.Text = dgv.Cells[3].Value.ToString();
                tab2mtbCelular.Text = dgv.Cells[4].Value.ToString();
            }
        }
    }
}
