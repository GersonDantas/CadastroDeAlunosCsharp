using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaRAD02.Model;

namespace AulaRAD02
{
    public partial class FrmCadAluno : Form
    {
        public FrmCadAluno()
        {
            InitializeComponent();
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            FrmListaCursos frm = new FrmListaCursos(this);            
            frm.Show();
        }

        internal void PreencherCurso(Curso cursoSelecionado)
        {
            txtCurso.Text = cursoSelecionado.NomeCurso;
        }
    }
}
