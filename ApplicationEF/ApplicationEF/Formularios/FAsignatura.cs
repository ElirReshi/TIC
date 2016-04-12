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
    public partial class FAsignatura : Form
    {
        #region Variables
        private int punto;
        private DataGridViewRow dgv;
        #endregion
        private void actualizar()
        {
            using (var db = new TICEntities1())
            {
                Grid.DataSource = db.list_asignatura.ToList();
            }
        }
        public FAsignatura()
        {
            InitializeComponent();
        }

        private void FAsignatura_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void tab1btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab1tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (string.IsNullOrEmpty(tab1tbAsignatura.Text))
            {
                MessageBox.Show("La asignatura está vacia");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.insert_asignatura(tab1tbCod.Text, tab1tbAsignatura.Text);
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
            else if (string.IsNullOrEmpty(tab2tbAsignatura.Text))
            {
                MessageBox.Show("La asignatura está vacia");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.modificar_asignatura(tab2tbCod.Text, tab2tbAsignatura.Text);
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
                    var pro = db.Asignatura.Where(q => q.CodAsignatura == tab3tbCod.Text).FirstOrDefault();
                    db.Asignatura.Remove(pro);
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
                tab2tbAsignatura.Text = dgv.Cells[1].Value.ToString();
            }
        }
    }
}
