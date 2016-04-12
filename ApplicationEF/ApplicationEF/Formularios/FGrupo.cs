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
    public partial class FGrupo : Form
    {
        #region Variables
        private int punto;
        private DataGridViewRow dgv;
        #endregion
        private void actualizar()
        {
            using (var db = new TICEntities1())
            {
                Grid.DataSource = db.list_grupo.ToList();
            }
        }
        public FGrupo()
        {
            InitializeComponent();
        }

        private void FGrupo_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            punto = e.RowIndex;
            if (punto >= 0)
            {
                dgv = Grid.Rows[punto];
                tab2tbCod.Text = dgv.Cells[0].Value.ToString();
                tab3tbCod.Text = tab2tbCod.Text;
                tab2tbGrupo.Text = dgv.Cells[1].Value.ToString();
            }
            }

        private void tab1btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab1tbCod.Text))
            {
                MessageBox.Show("El código está vacio");
            }
            else if (string.IsNullOrEmpty(tab1tbGrupo.Text))
            {
                MessageBox.Show("El grupo está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.insert_grupo(tab1tbCod.Text, tab1tbGrupo.Text);
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
            else if (string.IsNullOrEmpty(tab2tbGrupo.Text))
            {
                MessageBox.Show("El grupo está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.modificar_grupo(tab1tbCod.Text, tab1tbGrupo.Text);
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
                    var pro = db.Grupo.Where(q => q.CodGrupo == tab3tbCod.Text).FirstOrDefault();
                    db.Grupo.Remove(pro);
                    db.SaveChanges();
                }
                actualizar();
            }
        }
    }
}
