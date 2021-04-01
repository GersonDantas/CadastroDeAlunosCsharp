using AulaRAD02.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaRAD02
{
    public partial class FrmListaCursos : Form
    {
        private List<Curso> cursos = new List<Curso>();
        private FrmCadAluno formPai = new FrmCadAluno();

        public FrmListaCursos(FrmCadAluno frmPai)
        {
            formPai = frmPai;

            InitializeComponent();
            //Adicionando itens à lista de cursos:
            cursos.Add(new Curso() { IdCurso = 1,
                NomeCurso = "Tecnologia em Sistemas para Internet" });
            cursos.Add(new Curso()
            {
                IdCurso = 2,
                NomeCurso = "Tecnologia em Alimentos"
            });
            cursos.Add(new Curso()
            {
                IdCurso = 3,
                NomeCurso = "Técnico em Informática"
            });
            //Setando a fonte de dados, usando a lista:
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cursos;
        }

        private void dgvCursos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = e.RowIndex;
            Curso cursoSelecionado = cursos[linhaSelecionada];
            //Devolver o curso selecionado ao form de cadastro:
            formPai.PreencherCurso(cursoSelecionado);
            Close();
        }
    }
}
