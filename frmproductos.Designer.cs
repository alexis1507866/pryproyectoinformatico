namespace pryproyectoinformatico
{
    partial class frmproductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvinvenetario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvenetario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinvenetario
            // 
            this.dgvinvenetario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvenetario.Location = new System.Drawing.Point(74, 60);
            this.dgvinvenetario.Name = "dgvinvenetario";
            this.dgvinvenetario.Size = new System.Drawing.Size(522, 280);
            this.dgvinvenetario.TabIndex = 0;
            this.dgvinvenetario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinvenetario_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvinvenetario);
            this.Name = "Form1";
            this.Text = "frmproductos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvenetario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvinvenetario;
    }
}

