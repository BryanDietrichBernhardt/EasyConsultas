using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EasyConsultas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenCadastrarPaciente);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenCadastrarPaciente(object obj)
        {
            Application.Run(new frmCadastrarPaciente());
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenExibirPacientes);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenExibirPacientes(object obj)
        {
            Application.Run(new frmExibirPacientes());
        }
    }
}
