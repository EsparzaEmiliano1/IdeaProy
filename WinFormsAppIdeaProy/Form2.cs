using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppIdeaProy
{
    public partial class Form2 : Form
    {
        public ProductoInfo ProductoCreado { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxCategoria.Items.Add("Escritura");
            comboBoxCategoria.Items.Add("Oficina");
            comboBoxCategoria.Items.Add("Papeleria escolar");
            comboBoxCategoria.Items.Add("Tecnologia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(textBoxNomProd.Text) ||
                string.IsNullOrEmpty(textBoxPrecioUn.Text) ||
                string.IsNullOrEmpty(textBoxStock.Text) ||
                comboBoxCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }
            
            ProductoInfo nuevoProducto = new ProductoInfo( // crea y guarda el producto
                textBoxNomProd.Text,
                decimal.Parse(textBoxPrecioUn.Text), // Convertir a decimal
                int.Parse(textBoxStock.Text),     // Convertir a entero
                comboBoxCategoria.SelectedItem.ToString()
            );

            ProductoCreado = nuevoProducto;

            MessageBox.Show("Producto agregado correctamente.");
            this.DialogResult = DialogResult.OK; // Indicar que los datos se guardaron
            this.Close(); // Cerrar el formulario
        }
    }
}
