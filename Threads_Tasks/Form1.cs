using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads_Tasks
{
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void ReportarProgesso()
        {
            for (int i = 0; i <= 20; i++)
            {
                Thread.Sleep(1000);
                bw.ReportProgress(i);
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            ReportarProgesso();
        }

        private void executarButton_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
            executarButton.Enabled = false;
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            executarButton.Enabled = true;

            progressBar1.Value = progressBar1.Minimum;

            MessageBox.Show("Operação concluida com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
