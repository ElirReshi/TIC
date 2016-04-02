using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ApplicationEF.Formularios;

namespace ApplicationEF
{
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void FormPanel(Form Hijo)
        {
            if (this.MDI.Controls.Count > 0)
                this.MDI.Controls.RemoveAt(0);
            Hijo.TopLevel = false;
            Hijo.FormBorderStyle = FormBorderStyle.None;
            Hijo.Dock = DockStyle.Fill;
            this.MDI.Controls.Add(Hijo);
            this.MDI.Tag = Hijo;
            Hijo.Show();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FTurno>().FirstOrDefault();
            FTurno hijo = form ?? new FTurno();
            FormPanel(hijo);
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FGrupo>().FirstOrDefault();
            FGrupo hijo = form ?? new FGrupo();
            FormPanel(hijo);
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FAsignatura>().FirstOrDefault();
            FAsignatura hijo = form ?? new FAsignatura();
            FormPanel(hijo);
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FDocente>().FirstOrDefault();
            FDocente hijo = form ?? new FDocente();
            FormPanel(hijo);
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FResponsable>().FirstOrDefault();
            FResponsable hijo = form ?? new FResponsable();
            FormPanel(hijo);
        }

        private void maquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FMaquina>().FirstOrDefault();
            FMaquina hijo = form ?? new FMaquina();
            FormPanel(hijo);
        }

        private void blacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FBlacklist>().FirstOrDefault();
            FBlacklist hijo = form ?? new FBlacklist();
            FormPanel(hijo);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FDashboard>().FirstOrDefault();
            FDashboard hijo = form ?? new FDashboard();
            FormPanel(hijo);
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FCalendario>().FirstOrDefault();
            FCalendario hijo = form ?? new FCalendario();
            FormPanel(hijo);
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FExamen>().FirstOrDefault();
            FExamen hijo = form ?? new FExamen();
            FormPanel(hijo);
        }
    }
}
