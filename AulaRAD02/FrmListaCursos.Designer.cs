namespace AulaRAD02
{
    partial class FrmListaCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCurso,
            this.NomeCurso});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(472, 289);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentDoubleClick);
            // 
            // IdCurso
            // 
            this.IdCurso.DataPropertyName = "IdCurso";
            this.IdCurso.HeaderText = "Identificador";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.ReadOnly = true;
            this.IdCurso.Visible = false;
            // 
            // NomeCurso
            // 
            this.NomeCurso.DataPropertyName = "NomeCurso";
            this.NomeCurso.HeaderText = "Nome do Curso";
            this.NomeCurso.Name = "NomeCurso";
            this.NomeCurso.ReadOnly = true;
            this.NomeCurso.Width = 250;
            // 
            // FrmListaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 289);
            this.Controls.Add(this.dgvCursos);
            this.Name = "FrmListaCursos";
            this.Text = "Lista de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCurso;
    }
}