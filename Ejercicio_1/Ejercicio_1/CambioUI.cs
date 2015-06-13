using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.Properties;

namespace Ejercicio_1
{
    public partial class frm_CambioUI : Form
    {
        #region Campos y Propiedades
        private const int MAXDIF = 499;
        private float _importeCompra;
        private float _importeEntrega;
        private float _importeCambio;
        private float[] _metalicoNum;
        private string[] _metalicoStr;
        private Image[] _metalicoPic;
        #endregion

        public frm_CambioUI()
        {
            InitializeComponent();
            InicializarArrays();
        }

        private void InicializarArrays()
        {
            this._metalicoNum = new float[] {
                0.01F, 0.02F, 0.05F, 0.1F, 0.2F, 0.5F, 1, 2, 5, 10, 20, 50, 100, 200, 500
            };
            this._metalicoStr = new string[] 
            {
                "Moneda de 1 céntimos de Euro",
                "Moneda de 2 céntimos de Euro",
                "Moneda de 5 céntimos de Euro",
                "Moneda de 10 céntimos de Euro",
                "Moneda de 20 céntimos de Euro",
                "Moneda de 50 céntimos de Euro",
                "Moneda de 1 Euro",
                "Moneda de 2 Euros",
                "Billete de 5 Euros",
                "Billete de 10 Euros",
                "Billete de 20 Euros",
                "Billete de 50 Euros",
                "Billete de 100 Euros",
                "Billete de 200 Euros",
                "Billete de 500 Euros" 
            };

            this._metalicoPic = new Image[] {
                Resources.Euro_1_cent,
                Resources.Euro_2_cent,
                Resources.Euro_5_cent,
                Resources.Euro_10_cent,
                Resources.Euro_20_cent,
                Resources.Euro_50_cent,
                Resources.Euro_1_euro,
                Resources.Euro_2_euro,
                Resources.Euro_Billete_5,
                Resources.Euro_Billete_10,
                Resources.Euro_Billete_20,
                Resources.Euro_Billete_50,
                Resources.Euro_Billete_100,
                Resources.Euro_Billete_200,
                Resources.Euro_Billete_500
            };
        }

        private void frm_CambioUI_Load(object sender, EventArgs e)
        {
            //nombrar labels y botón
            string[] labels = new string[] { "Importe de la compra", "Cantidad entregada", "Importe a devolver" };
            int i = 0;
            foreach (Control item in this.grbOperaciones.Controls)
            {
                if (item is Label)
                    ((Label)item).Text = labels[i++];
                else if (item is Button)
                {
                    ((Button)item).Text = "Calcular";
                    ((Button)item).Click += new EventHandler(boton_click);
                    ((Button)item).Enabled = false;
                }
                else if (item is TextBox)
                    ((TextBox)item).TextChanged += new EventHandler(texto_cambiado);
            }
        }
        void texto_cambiado(object sender, EventArgs e)
        {
            //TODO mejorar...
            if (((TextBox)sender).Text.Length > 0)
                this.btnCalcular.Enabled = true;
        }

        void boton_click(object sender, EventArgs e)
        {
            Calcular(sender);
        }

        private void Calcular(object sender)
        {
            //Resetear lista y FlowPanel
            this.lsbResultado.Items.Clear();
            this.flowPanel.Controls.Clear();
            //Resetear errores
            this.errorProvider.SetError(this.tbxImporteEntrega, null);
            this.errorProvider.SetError(this.tbxImporteCambio, null);
            this.errorProvider.SetError(this.tbxImporteCompra, null);
            this.errorProvider.SetError((Button)sender, null);

            foreach (Control tbx in this.grbOperaciones.Controls)
            {
                if (tbx is TextBox)
                    if (((TextBox)tbx).Text.Contains('.'))
                        this.errorProvider.SetError((TextBox)tbx, "Los decimales deben ir separados por coma");
            }

            //Obtener los importes:
            if (!float.TryParse(this.tbxImporteCompra.Text, out this._importeCompra))
            {
                this.errorProvider.SetError(this.tbxImporteCompra, "La cantidad debe ser un número positivo");
                this.tbxImporteCompra.Focus();
                this.tbxImporteCompra.SelectAll();
                return;
            }
            if (!float.TryParse(this.tbxImporteEntrega.Text, out this._importeEntrega))
            {
                this.errorProvider.SetError(this.tbxImporteEntrega, "La cantidad debe ser un número positivo");
                this.tbxImporteEntrega.Focus();
                this.tbxImporteEntrega.SelectAll();
                return;
            }

            if (this._importeEntrega - this._importeCompra > MAXDIF)
            {
                this.errorProvider.SetError(((Button)sender), "La cantidad entregada excede el límite soportado");
                return;
            }

            //calcular
            if (this._importeCompra < 0 ||
            this._importeEntrega < 0)
            {
                this.errorProvider.SetError((Button)sender, "El precio o la entrega contiene un valor inválido");
                return;
            }
            else if (this._importeCompra > this._importeEntrega)
            {
                this.errorProvider.SetError((Button)sender, "El cliente no ha pagado la cantidad mínima");
                this.tbxImporteEntrega.Focus();
                this.tbxImporteEntrega.SelectAll();
                return;
            }


            this.tbxImporteCambio.Text = (this._importeCambio = this._importeEntrega - this._importeCompra)
                .ToString("F2");

            Indices();
            cargarTextoImagen();
        }

        private IEnumerable<int> Indices()  //Secuencia de indices de solo lectura.
        {
            int len = this._metalicoNum.Length - 1; //indice es la posicion de la moneda mas grande posible.
            do
            {
                while (this._importeCambio >= this._metalicoNum[len]) //mientras cambio >= que moneda mas grande.
                {
                    this._importeCambio -= this._metalicoNum[len]; //se resta el valor de la moneda/billete al cambio.
                    yield return len; //almacenamos el indice en la secuencia.
                }
                len--; //sino pasamos a la moneda anterior mas grande.
            } while (this._importeCambio >= this._metalicoNum[0]); //se repite mientras cambio sea mayor o igual que 1 céntimo.
        }

        void cargarTextoImagen()
        {
            foreach (int item in this.Indices())
            {
                this.lsbResultado.Items.Add(this._metalicoStr[item]);
                this.flowPanel.Controls.Add(new PictureBox()
                {
                    Image = this._metalicoPic[item],
                    SizeMode = PictureBoxSizeMode.StretchImage
                }
                );
            }
        }
    }
}
