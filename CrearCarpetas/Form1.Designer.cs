namespace CrearCarpetas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerar = new System.Windows.Forms.Button();
            this.ofdBuscarExcel = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgObras = new System.Windows.Forms.DataGridView();
            this.colObras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgObras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(254, 58);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // ofdBuscarExcel
            // 
            this.ofdBuscarExcel.FileName = "openFileDialog1";
            this.ofdBuscarExcel.Title = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(301, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(12, 31);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(283, 20);
            this.txtArchivo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archivo";
            // 
            // dgObras
            // 
            this.dgObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colObras});
            this.dgObras.Location = new System.Drawing.Point(21, 89);
            this.dgObras.Name = "dgObras";
            this.dgObras.Size = new System.Drawing.Size(146, 382);
            this.dgObras.TabIndex = 4;
            // 
            // colObras
            // 
            this.colObras.Frozen = true;
            this.colObras.HeaderText = "Obras";
            this.colObras.Name = "colObras";
            this.colObras.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 483);
            this.Controls.Add(this.dgObras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Cargar Carpetas";
            ((System.ComponentModel.ISupportInitialize)(this.dgObras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.OpenFileDialog ofdBuscarExcel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgObras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObras;
    }
}

