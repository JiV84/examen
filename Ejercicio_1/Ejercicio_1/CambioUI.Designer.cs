namespace Ejercicio_1
{
    partial class frm_CambioUI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxImporteCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxImporteEntrega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxImporteCambio = new System.Windows.Forms.TextBox();
            this.lsbResultado = new System.Windows.Forms.ListBox();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbLista = new System.Windows.Forms.GroupBox();
            this.grbImagenes = new System.Windows.Forms.GroupBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbOperaciones.SuspendLayout();
            this.grbLista.SuspendLayout();
            this.grbImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tbxImporteCompra
            // 
            this.tbxImporteCompra.Location = new System.Drawing.Point(47, 76);
            this.tbxImporteCompra.Name = "tbxImporteCompra";
            this.tbxImporteCompra.Size = new System.Drawing.Size(135, 20);
            this.tbxImporteCompra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // tbxImporteEntrega
            // 
            this.tbxImporteEntrega.Location = new System.Drawing.Point(47, 142);
            this.tbxImporteEntrega.Name = "tbxImporteEntrega";
            this.tbxImporteEntrega.Size = new System.Drawing.Size(135, 20);
            this.tbxImporteEntrega.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // tbxImporteCambio
            // 
            this.tbxImporteCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImporteCambio.Location = new System.Drawing.Point(47, 260);
            this.tbxImporteCambio.Name = "tbxImporteCambio";
            this.tbxImporteCambio.Size = new System.Drawing.Size(135, 20);
            this.tbxImporteCambio.TabIndex = 5;
            // 
            // lsbResultado
            // 
            this.lsbResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbResultado.FormattingEnabled = true;
            this.lsbResultado.Location = new System.Drawing.Point(3, 16);
            this.lsbResultado.Name = "lsbResultado";
            this.lsbResultado.Size = new System.Drawing.Size(285, 406);
            this.lsbResultado.TabIndex = 6;
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.btnCalcular);
            this.grbOperaciones.Controls.Add(this.label1);
            this.grbOperaciones.Controls.Add(this.tbxImporteCompra);
            this.grbOperaciones.Controls.Add(this.tbxImporteCambio);
            this.grbOperaciones.Controls.Add(this.label2);
            this.grbOperaciones.Controls.Add(this.label3);
            this.grbOperaciones.Controls.Add(this.tbxImporteEntrega);
            this.grbOperaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbOperaciones.Location = new System.Drawing.Point(0, 0);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(200, 425);
            this.grbOperaciones.TabIndex = 7;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(44, 317);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 54);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // grbLista
            // 
            this.grbLista.Controls.Add(this.lsbResultado);
            this.grbLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbLista.Location = new System.Drawing.Point(200, 0);
            this.grbLista.Name = "grbLista";
            this.grbLista.Size = new System.Drawing.Size(291, 425);
            this.grbLista.TabIndex = 8;
            this.grbLista.TabStop = false;
            this.grbLista.Text = "Resultado";
            // 
            // grbImagenes
            // 
            this.grbImagenes.Controls.Add(this.flowPanel);
            this.grbImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbImagenes.Location = new System.Drawing.Point(491, 0);
            this.grbImagenes.Name = "grbImagenes";
            this.grbImagenes.Size = new System.Drawing.Size(437, 425);
            this.grbImagenes.TabIndex = 9;
            this.grbImagenes.TabStop = false;
            this.grbImagenes.Text = "Imagenes";
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(3, 16);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(431, 406);
            this.flowPanel.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_CambioUI
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 425);
            this.Controls.Add(this.grbImagenes);
            this.Controls.Add(this.grbLista);
            this.Controls.Add(this.grbOperaciones);
            this.Name = "frm_CambioUI";
            this.Text = "Devolución de Cambio en metálico";
            this.Load += new System.EventHandler(this.frm_CambioUI_Load);
            this.grbOperaciones.ResumeLayout(false);
            this.grbOperaciones.PerformLayout();
            this.grbLista.ResumeLayout(false);
            this.grbImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxImporteCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxImporteEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxImporteCambio;
        private System.Windows.Forms.ListBox lsbResultado;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbLista;
        private System.Windows.Forms.GroupBox grbImagenes;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}

