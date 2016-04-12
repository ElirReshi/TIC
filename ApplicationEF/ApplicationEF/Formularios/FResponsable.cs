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
    public partial class FResponsable : Form
    {
        #region Variables
        private int punto;
        private DataGridViewRow dgv;
        #endregion
        public FResponsable()
        {
            InitializeComponent();
        }
        private void actualizar()
        {
            using (var db = new TICEntities1())
            {
                Grid.DataSource = db.list_responsable.ToList();
            }
        }
        private void FResponsable_Load(object sender, EventArgs e)
        {
            using (var db = new TICEntities1())
            {
                var pro = db.Database.SqlQuery<string>("select CodTurno from dbo.Turno").ToList();
                tab1cbTurno.DataSource = pro;
                tab2cbTurno.DataSource = pro;
            }
            actualizar();
            //tab1cbTurno.ValueMember = ValueMember;
        }

        private void tab1btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab1tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (tab1cbTurno.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El turno invalido");
            }
            else if (!(tab1mtbCedula.MaskFull))
            {
                MessageBox.Show("La cédula está vacia");
            }
            else if (string.IsNullOrEmpty(tab1tbNombre.Text))
            {
                MessageBox.Show("El Nombre está vacia");
            }
            else if (string.IsNullOrEmpty(tab1tbApellido.Text))
            {
                MessageBox.Show("El Apellido está vacia");
            }
            else if (!(tab1mtbCelular.MaskFull))
            {
                MessageBox.Show("El celular está vacia");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.insert_responsable(tab1tbCod.Text, tab1cbTurno.Text, tab1mtbCedula.Text, tab1tbNombre.Text, tab1tbApellido.Text, int.Parse(tab1mtbCelular.Text));
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
                tab2cbTurno.Text = dgv.Cells[1].Value.ToString();
                tab2mtbCedula.Text = dgv.Cells[2].Value.ToString();
                tab2tbNombre.Text = dgv.Cells[3].Value.ToString();
                tab2tbApellido.Text = dgv.Cells[4].Value.ToString();
                tab2mtbCelular.Text = dgv.Cells[5].Value.ToString();
            }
        }

        private void tab2btModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab2tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (tab2cbTurno.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El turno invalido");
            }
            else if (!(tab2mtbCedula.MaskFull))
            {
                MessageBox.Show("La cédula está vacia");
            }
            else if (string.IsNullOrEmpty(tab2tbNombre.Text))
            {
                MessageBox.Show("El Nombre está vacia");
            }
            else if (string.IsNullOrEmpty(tab2tbApellido.Text))
            {
                MessageBox.Show("El Apellido está vacia");
            }
            else if (!(tab2mtbCelular.MaskFull))
            {
                MessageBox.Show("El celular está vacia");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.modificar_responsable(tab2tbCod.Text, tab2cbTurno.Text, tab2mtbCedula.Text, tab2tbNombre.Text, tab2tbApellido.Text, int.Parse(tab2mtbCelular.Text));
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
                    var pro = db.Turno.Where(q => q.CodTurno == tab3tbCod.Text).FirstOrDefault();
                    db.Turno.Remove(pro);
                    db.SaveChanges();
                }
                actualizar();
            }
        }

        private void tab1mtbCedula_Click(object sender, EventArgs e)
        {
            tab1mtbCedula.Select(0, 0);
        }

        private void tab1mtbCelular_Click(object sender, EventArgs e)
        {
            tab1mtbCelular.Select(0, 0);
        }

        private void tab2mtbCedula_Click(object sender, EventArgs e)
        {
            tab2mtbCedula.Select(0, 0);
        }

        private void tab2mtbCelular_Click(object sender, EventArgs e)
        {
            tab2mtbCelular.Select(0, 0);
        }
    }
}
