
namespace ContagemSexo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btresultado = new System.Windows.Forms.Button();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.rdmasculino = new System.Windows.Forms.RadioButton();
            this.rdfeminino = new System.Windows.Forms.RadioButton();
            this.chhomossexual = new System.Windows.Forms.CheckBox();
            this.chheterossexual = new System.Windows.Forms.CheckBox();
            this.gbsexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(12, 93);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(142, 39);
            this.btcadastrar.TabIndex = 0;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btresultado
            // 
            this.btresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btresultado.Location = new System.Drawing.Point(160, 93);
            this.btresultado.Name = "btresultado";
            this.btresultado.Size = new System.Drawing.Size(142, 39);
            this.btresultado.TabIndex = 1;
            this.btresultado.Text = "Resultado";
            this.btresultado.UseVisualStyleBackColor = true;
            this.btresultado.Click += new System.EventHandler(this.btresultado_Click);
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.chheterossexual);
            this.gbsexo.Controls.Add(this.chhomossexual);
            this.gbsexo.Controls.Add(this.rdfeminino);
            this.gbsexo.Controls.Add(this.rdmasculino);
            this.gbsexo.Location = new System.Drawing.Point(12, 12);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(290, 75);
            this.gbsexo.TabIndex = 2;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo";
            // 
            // rdmasculino
            // 
            this.rdmasculino.AutoSize = true;
            this.rdmasculino.Location = new System.Drawing.Point(6, 19);
            this.rdmasculino.Name = "rdmasculino";
            this.rdmasculino.Size = new System.Drawing.Size(73, 17);
            this.rdmasculino.TabIndex = 0;
            this.rdmasculino.TabStop = true;
            this.rdmasculino.Text = "Masculino";
            this.rdmasculino.UseVisualStyleBackColor = true;
            // 
            // rdfeminino
            // 
            this.rdfeminino.AutoSize = true;
            this.rdfeminino.Location = new System.Drawing.Point(6, 42);
            this.rdfeminino.Name = "rdfeminino";
            this.rdfeminino.Size = new System.Drawing.Size(67, 17);
            this.rdfeminino.TabIndex = 1;
            this.rdfeminino.TabStop = true;
            this.rdfeminino.Text = "Feminino";
            this.rdfeminino.UseVisualStyleBackColor = true;
            // 
            // chhomossexual
            // 
            this.chhomossexual.AutoSize = true;
            this.chhomossexual.Location = new System.Drawing.Point(148, 19);
            this.chhomossexual.Name = "chhomossexual";
            this.chhomossexual.Size = new System.Drawing.Size(89, 17);
            this.chhomossexual.TabIndex = 2;
            this.chhomossexual.Text = "Homossexual";
            this.chhomossexual.UseVisualStyleBackColor = true;
            // 
            // chheterossexual
            // 
            this.chheterossexual.AutoSize = true;
            this.chheterossexual.Location = new System.Drawing.Point(148, 42);
            this.chheterossexual.Name = "chheterossexual";
            this.chheterossexual.Size = new System.Drawing.Size(93, 17);
            this.chheterossexual.TabIndex = 3;
            this.chheterossexual.Text = "Héterossexual";
            this.chheterossexual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chheterossexual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 148);
            this.Controls.Add(this.gbsexo);
            this.Controls.Add(this.btresultado);
            this.Controls.Add(this.btcadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btresultado;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.RadioButton rdfeminino;
        private System.Windows.Forms.RadioButton rdmasculino;
        private System.Windows.Forms.CheckBox chheterossexual;
        private System.Windows.Forms.CheckBox chhomossexual;
    }
}

