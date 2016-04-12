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
    public partial class FMaquina : Form
    {
        #region Variables
        private int punto;
        private DataGridViewRow dgv;
        #endregion
        public FMaquina()
        {
            InitializeComponent();
        }
        private void actualizar()
        {
            using (var db = new TICEntities1())
            {
                Grid.DataSource = db.list_maquina.ToList();
            }
        }
        private void tab1btAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab1tbID.Text))
            {
                MessageBox.Show("El ID está vacio");
            }
            else if (string.IsNullOrEmpty(tab1tbFabricante.Text))
            {
                MessageBox.Show("El fabricante está vacio");
            }
            else if (string.IsNullOrEmpty(tab1tbModelo.Text))
            {

            }
            else if (string.IsNullOrEmpty(tab1tbCPU.Text))
            {

            }
            else if (tab1cbRAM.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El Ram invalido");
            }
            else if (string.IsNullOrEmpty(tab1tbGPU.Text))
            {

            }
            else if (tab1cbHDD.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El HDD invalido");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.insert_maquina(int.Parse(tab1tbID.Text), tab1tbFabricante.Text, tab1tbModelo.Text, tab1tbCPU.Text, int.Parse(tab1cbRAM.Text), tab1tbGPU.Text, int.Parse(tab1cbHDD.Text));
                }
                actualizar();
            }
        }
        private void tab2btModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab2tbID.Text))
            {
                MessageBox.Show("El ID está vacio");
            }
            else if (string.IsNullOrEmpty(tab2tbFabricante.Text))
            {
                MessageBox.Show("El fabricante está vacio");
            }
            else if (string.IsNullOrEmpty(tab2tbModelo.Text))
            {

            }
            else if (string.IsNullOrEmpty(tab2tbCPU.Text))
            {

            }
            else if (tab2cbRAM.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El Ram invalido");
            }
            else if (string.IsNullOrEmpty(tab2tbGPU.Text))
            {

            }
            else if (tab2cbHDD.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El HDD invalido");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    db.modificar_maquina(int.Parse(tab2tbID.Text), tab2tbFabricante.Text, tab2tbModelo.Text, tab2tbCPU.Text, int.Parse(tab2cbRAM.Text), tab2tbGPU.Text, int.Parse(tab2cbHDD.Text));
                }
                actualizar();
            }
        }
        private void tab3btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tab2tbID.Text))
            {
                MessageBox.Show("El ID está vacio");
            }
            else
            {
                using (var db = new TICEntities1())
                {
                    var pro = db.Maquina.Where(q => q.NumMaquina == int.Parse(tab3tbID.Text)).FirstOrDefault();
                    db.Maquina.Remove(pro);
                    db.SaveChanges();
                }
                actualizar();
            }
        }
        private void FMaquina_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            punto = e.RowIndex;
            if (punto >= 0)
            {
                dgv = Grid.Rows[punto];
                tab2tbID.Text = dgv.Cells[0].Value.ToString();
                tab3tbID.Text = tab2tbID.Text;
                tab2tbFabricante.Text = dgv.Cells[1].Value.ToString();
                tab2tbModelo.Text = dgv.Cells[2].Value.ToString();
                tab2tbCPU.Text = dgv.Cells[3].Value.ToString();
                tab2cbRAM.Text = dgv.Cells[4].Value.ToString();
                tab2tbGPU.Text = dgv.Cells[5].Value.ToString();
                tab2cbHDD.Text = dgv.Cells[6].Value.ToString();
            }
        }
    }
}
