using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafePass.Forms
{
    public partial class AppForm : Form
    {
        private Form _formulario;
        public AppForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            AbrirFomulario(home);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja finalizar o programa?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void AbrirFomulario(Form form)
        {
            _formulario?.Close();

            _formulario = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


            pnForms.Controls.Add(_formulario);
            _formulario.Show();

        }

        private void btnBuscarContas_Click(object sender, EventArgs e)
        {
            BuscarContasForm form = new BuscarContasForm();
            AbrirFomulario(form);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
