using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class frm_palindromos : Form
    {

        public string Ruta { get; set; }
        public event EventHandler RutaEstablecida;
        private List<string> _coleccion;

        public frm_palindromos()
        {
            InitializeComponent();
            _coleccion = new List<string>();
        }

        private void btn_AbrirFichero_Click(object sender, EventArgs e)
        {
            this.ofdAbrirFichero.ShowDialog();
        }

        private void frm_palindromos_Load(object sender, EventArgs e)
        {
            this.ofdAbrirFichero.Filter = "(Archivo de texto) |*.txt";
            this.ofdAbrirFichero.FileName = string.Empty;
            this.ofdAbrirFichero.FileOk += ofdAbrirFichero_FileOk;
            this.RutaEstablecida += new EventHandler(frm_ruta_ok);
            //
            this.AcceptButton = this.btn_AbrirFichero;
            this.CancelButton = this.btnSalir;
        }
        void frm_ruta_ok(object sender, EventArgs e)
        {
            ComprobarPalabras();
        }

        private void ComprobarPalabras()
        {
            this._coleccion.Clear(); this.lsbPalindromos.Items.Clear();
            using (StreamReader sr = new StreamReader(this.Ruta, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    int i = 0;
                    string sinPuntuacion = string.Empty;
                    string[] palabras = linea.Split(' ');

                    foreach (var item in palabras)
                    {
                        if (string.IsNullOrEmpty(item))
                            continue;
                        //quitar caracteres de puntuación
                        int len = 0;
                        sinPuntuacion = "";
                        while (len < item.Length)
                        {
                            if (char.IsLetter(item[len]))
                                sinPuntuacion += item[len];
                            len++;
                        }
                        //quitar tildes
                        string NoTildes = new Regex("[^a-zñ]*").Replace(sinPuntuacion.ToLowerInvariant().Normalize(NormalizationForm.FormD), "");
                        //comprobar si es palindromo
                        if (esPalindromo(NoTildes))
                            this._coleccion.Add(NoTildes);
                    }
                }
            }
            if (this._coleccion.Count < 1)
            {
                this.lsbPalindromos.Items.Add("No existe ninguna palabra palíndromo");
                return;
            }
            this.lsbPalindromos.Items.AddRange(this._coleccion.ToArray());
        }

        private bool esPalindromo(string NoTildes)
        {
            int a = 0, b = NoTildes.Length - 1;
            while (a < b)
            {
                if (NoTildes[a++] != NoTildes[b--])
                    return false;
            }
            return true;
        }

        void ofdAbrirFichero_FileOk(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.ofdAbrirFichero.FileName))
                return;
            this.Ruta = this.ofdAbrirFichero.FileName;
            this.OnRutaEstablecida(sender, e);
        }
        //trigger
        void OnRutaEstablecida(object sender, EventArgs e)
        {
            if (this.RutaEstablecida != null)
                this.RutaEstablecida(sender, e);
        }

        private void chbOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                if (((CheckBox)sender).Checked)
                {
                    this.lsbPalindromos.Visible = false;
                    this.lsbPalindromos.Sorted = true;
                    this.lsbPalindromos.Visible = true;
                }
                else
                {
                    this.lsbPalindromos.Visible = false;
                    this.lsbPalindromos.Items.Clear();
                    this.lsbPalindromos.Sorted = false;
                    this.lsbPalindromos.Items.AddRange(this._coleccion.ToArray());
                    this.lsbPalindromos.Visible = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_palindromos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = System.Windows.Forms.DialogResult.Ignore;
            res = MessageBox.Show(this, "Esta seguro de que desea salir?", "AVISO", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (res == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
            
        }

        private void frm_palindromos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frm_palindromos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                e.IsInputKey = true;
        }

        private void frm_palindromos_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
