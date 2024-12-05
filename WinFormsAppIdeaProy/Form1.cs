using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppIdeaProy
{
    public partial class Form1 : Form
    {
        DataTable ticket;

        
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }
        //Declara un diccionario global para relacionar los nombres del ComboBox con los IDs de productos.
        private Dictionary<string, int> comboBoxMapping = new Dictionary<string, int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarComboBox();
        }
        private void InicializarComboBox()
        {
            comboBoxMapping.Clear();
            comboBox1.Items.Clear();

            // Relacionar las opciones con IDs
            comboBoxMapping.Add("Producto 1", 1);
            comboBoxMapping.Add("Producto 2", 2);
            comboBoxMapping.Add("Producto 3", 3);
            comboBoxMapping.Add("Producto 4", 4);
            comboBoxMapping.Add("Producto 5", 5);
            comboBoxMapping.Add("Producto 6", 6);
            comboBoxMapping.Add("Producto 7", 7);
            comboBoxMapping.Add("Producto 8", 8);

            // Agregar los nombres al ComboBox
            foreach (var item in comboBoxMapping.Keys)
            {
                comboBox1.Items.Add(item);
            }
        }

        private List<ProductoInfo> productos = new List<ProductoInfo>();
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Producto válido antes de añadir.");
                return;
            }

            // Obtén el nombre seleccionado del ComboBox
            string selectedName = comboBox1.SelectedItem.ToString();

            // Obtén el ID correspondiente usando el diccionario
            if (!comboBoxMapping.TryGetValue(selectedName, out int productID))
            {
                MessageBox.Show("El producto seleccionado no tiene un ID asignado.");
                return;
            }

            // Busca el producto en la lista según el ID
            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            if (productoSeleccionado == null)
            {
                MessageBox.Show($"No se encontró el producto con ID {productID}.");
                return;
            }

            // Mostrar el Form2 para editar o agregar información
            Form2 form2 = new Form2(productoSeleccionado.Id);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ProductoInfo nuevoProducto = form2.ProductoCreado;
                productos.Add(nuevoProducto);

                // Reflejar los cambios en el ComboBox o cualquier otra parte de la UI
                MessageBox.Show($"Producto {nuevoProducto.Nombre} añadido correctamente.");
            }
        }

        private PictureBox ObtenerPictureBox(int idProducto)
        {
            switch (idProducto)
            {
                case 1: return pictureBoxProd1;
                case 2: return pictureBoxProd2;
                case 3: return pictureBoxProd3;
                case 4: return pictureBoxProd4;
                case 5: return pictureBoxProd5;
                case 6: return pictureBoxProd6;
                case 7: return pictureBoxProd7;
                case 8: return pictureBoxProd8;
                default: return null;
            }
        }

        private void ActualizarComboBox()
        {
            comboBox1.Items.Clear(); // Limpia las opciones existentes

            foreach (var producto in productos)
            {
                comboBox1.Items.Add(producto); // Agrega el objeto completo
            }
            comboBox1.DisplayMember = "Nombre"; // Muestra solo el nombre en el ComboBox
        }


        private void Iniciar()
        {
            //ticket = new DataTable();
            //ticket.Columns.Add("Producto");
            //ticket.Columns.Add("Categoria");
            //ticket.Columns.Add("Existencia");
            //ticket.Columns.Add("Precio");
            ////ticket.Rows.Add("");          ///Hay que poner numeracion de cuantos productos/conjunto de productos van (?) 
            //dataGridViewTicket.DataSource = ticket;

        }


        //private void Guardar()
        //{
        //    usuarioModel modelo = new usuarioModel()
        //    {                                                    ejemplo de otro programa de como guardar los datos
        //        Nombre = textBoxNombre.Text,                     pero es necesario crear dinamicamente un "ticket" 
        //        Apellidos = textBoxApellidos.Text,               usando clases agregando carpetas como la practica 
        //        Edad = int.Parse(textBoxEdad.Text),              del video
        //        Carrera = textBoxCarrera.Text
        //    };
        //    dato.Guardar(modelo);

        //}


        private void labelProdNum1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
         
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un producto válido a modificar.");
                return;
            }

            // Busca el producto en la lista
            string selectedOption = comboBox1.SelectedItem.ToString();
            ProductoInfo prodSeleccionado = productos.FirstOrDefault(p => p.Nombre == selectedOption);

            if (prodSeleccionado == null)
            {
                MessageBox.Show("El producto seleccionado no se encuentra en la lista.");
                return;
            }

            // Pasa el producto seleccionado al segundo formulario
            Form4 formMod = new Form4(prodSeleccionado);
            if (formMod.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Producto modificado con éxito.");
            }
        

    }
}
}
