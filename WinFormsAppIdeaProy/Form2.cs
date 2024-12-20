﻿using System;
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
        private int productoID;
        public ProductoInfo ProductoCreado { get; private set; }


        public Form2(int id)
        {
            InitializeComponent();
            productoID = id; // Establece el ID recibido
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
                string.IsNullOrEmpty(textBoxDescrip.Text) ||
                string.IsNullOrEmpty(textBoxPrecioUn.Text) ||
                string.IsNullOrEmpty(textBoxStock.Text) ||
                comboBoxCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            // Crear el producto con el ID proporcionado
            ProductoInfo nuevoProducto = new ProductoInfo(
                productoID,
                textBoxNomProd.Text,
                textBoxDescrip.Text,
                decimal.Parse(textBoxPrecioUn.Text),
                int.Parse(textBoxStock.Text),
                comboBoxCategoria.SelectedItem.ToString()
            );

            ProductoCreado = nuevoProducto;

            MessageBox.Show("Producto agregado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
