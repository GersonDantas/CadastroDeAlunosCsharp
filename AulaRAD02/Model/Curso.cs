using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaRAD02.Model
{
    public class Curso
    {
        private int idCurso;
        private string nomeCurso;

        /// <summary>
        /// Propriedade para acessar o idCurso.
        /// identificador do curso.
        /// </summary>
        public int IdCurso { get => idCurso; set => idCurso = value; }

        /// <summary>
        /// Nome do curso
        /// </summary>
        public string NomeCurso { get => nomeCurso; set => nomeCurso = value; }
    }
}
