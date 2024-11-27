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

        }
    }
}
