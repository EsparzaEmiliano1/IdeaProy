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
    public partial class Form4 : Form
    {
        
        private string productoSeleccionado;
        public Form4(string option)
        {
            InitializeComponent();
            productoSeleccionado = option;
            // Usa el valor como desees, por ejemplo:
            labelOption.Text = productoSeleccionado; // Si tienes un Label para mostrarlo
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategoriaModf.Items.Add("Escritura");
            comboBoxCategoriaModf.Items.Add("Oficina");
            comboBoxCategoriaModf.Items.Add("Papeleria escolar");
            comboBoxCategoriaModf.Items.Add("Tecnologia");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
