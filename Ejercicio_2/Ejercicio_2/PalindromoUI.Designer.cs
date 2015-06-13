namespace Ejercicio_2
{
    partial class frm_palindromos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.ofdAbrirFichero = new System.Windows.Forms.OpenFileDialog();
            this.btn_AbrirFichero = new System.Windows.Forms.Button();
            this.grbPalindromos = new System.Windows.Forms.GroupBox();
            this.lsbPalindromos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbOrdenar = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbPalindromos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdAbrirFichero
            // 
            this.ofdAbrirFichero.FileName = "openFileDialog1";
            // 
            // btn_AbrirFichero
            // 
            this.btn_AbrirFichero.Location = new System.Drawing.Point(12, 56);
            this.btn_AbrirFichero.Name = "btn_AbrirFichero";
            this.btn_AbrirFichero.Size = new System.Drawing.Size(99, 43);
            this.btn_AbrirFichero.TabIndex = 0;
            this.btn_AbrirFichero.Text = "AbrirFichero";
            this.btn_AbrirFichero.UseVisualStyleBackColor = true;
            this.btn_AbrirFichero.Click += new System.EventHandler(this.btn_AbrirFichero_Click);
            // 
            // grbPalindromos
            // 
            this.grbPalindromos.Controls.Add(this.btnSalir);
            this.grbPalindromos.Controls.Add(this.chbOrdenar);
            this.grbPalindromos.Controls.Add(this.label1);
            this.grbPalindromos.Controls.Add(this.lsbPalindromos);
            this.grbPalindromos.Controls.Add(this.btn_AbrirFichero);
            this.grbPalindromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbPalindromos.Location = new System.Drawing.Point(0, 0);
            this.grbPalindromos.Name = "grbPalindromos";
            this.grbPalindromos.Size = new System.Drawing.Size(452, 292);
            this.grbPalindromos.TabIndex = 1;
            this.grbPalindromos.TabStop = false;
            // 
            // lsbPalindromos
            // 
            this.lsbPalindromos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbPalindromos.FormattingEnabled = true;
            this.lsbPalindromos.Location = new System.Drawing.Point(3, 129);
            this.lsbPalindromos.Name = "lsbPalindromos";
            this.lsbPalindromos.ScrollAlwaysVisible = true;
            this.lsbPalindromos.Size = new System.Drawing.Size(446, 160);
            this.lsbPalindromos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Palabras palíndromo:";
            // 
            // chbOrdenar
            // 
            this.chbOrdenar.AutoSize = true;
            this.chbOrdenar.Location = new System.Drawing.Point(212, 106);
            this.chbOrdenar.Name = "chbOrdenar";
            this.chbOrdenar.Size = new System.Drawing.Size(101, 17);
            this.chbOrdenar.TabIndex = 3;
            this.chbOrdenar.Text = "Listar Ordenado";
            this.chbOrdenar.UseVisualStyleBackColor = true;
            this.chbOrdenar.CheckedChanged += new System.EventHandler(this.chbOrdenar_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(320, 56);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 43);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frm_palindromos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 292);
            this.Controls.Add(this.grbPalindromos);
            this.KeyPreview = true;
            this.Name = "frm_palindromos";
            this.Text = "Buscador de palíndromos en Ficheros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_palindromos_FormClosing);
            this.Load += new System.EventHandler(this.frm_palindromos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_palindromos_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frm_palindromos_PreviewKeyDown);
            this.grbPalindromos.ResumeLayout(false);
            this.grbPalindromos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdAbrirFichero;
        private System.Windows.Forms.Button btn_AbrirFichero;
        private System.Windows.Forms.GroupBox grbPalindromos;
        private System.Windows.Forms.ListBox lsbPalindromos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbOrdenar;
        private System.Windows.Forms.Button btnSalir;
    }
}

