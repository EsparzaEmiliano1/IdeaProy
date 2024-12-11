using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppIdeaProy
{
    public partial class Form1 : Form
    {
        private List<ProductoInfo> productos = new List<ProductoInfo>(); // Lista de productos
        private Dictionary<string, int> comboBoxMapping = new Dictionary<string, int>(); // Relación ComboBox - ID
        private Dictionary<int, Label> labelMapping = new Dictionary<int, Label>(); // Relación ID - Label

        public Form1()
        {
            InitializeComponent();
            InicializarProductosPorDefecto();
            InicializarLabels();
            InicializarComboBox();
        }

        // Inicializa los Labels con texto predeterminado
        private void InicializarLabels()
        {
            labelMapping.Add(1, labelNomProd1);
            labelMapping.Add(2, labelNomProd2);
            labelMapping.Add(3, labelNomProd3);
            labelMapping.Add(4, labelNomProd4);
            labelMapping.Add(5, labelNomProd5);
            labelMapping.Add(6, labelNomProd6);
            labelMapping.Add(7, labelNomProd7);
            labelMapping.Add(8, labelNomProd8);

            foreach (var kvp in labelMapping)
            {
                kvp.Value.Text = $"Producto indefinido {kvp.Key}";
            }
        }

        // Inicializa la lista de productos con valores predeterminados
        private void InicializarProductosPorDefecto()
        {
            for (int i = 1; i <= 8; i++)
            {
                productos.Add(new ProductoInfo(i, $"Producto {i}", 0m, 0, "Sin categoría"));
            }
        }

        // Llena el ComboBox con los nombres de los productos y mapea sus IDs
        private void InicializarComboBox()
        {
            comboBoxMapping.Clear();
            comboBox1.Items.Clear();

            foreach (var producto in productos)
            {
                string productoNombre = producto.Nombre;
                comboBoxMapping.Add(productoNombre, producto.Id);
                comboBox1.Items.Add(productoNombre);
            }
        }

        // Actualiza el Label asociado a un producto
        private void ActualizarLabelProducto(int idProducto, string nuevoNombre)
        {
            if (labelMapping.TryGetValue(idProducto, out Label label))
            {
                label.Text = string.IsNullOrWhiteSpace(nuevoNombre)
                    ? $"Producto indefinido {idProducto}"
                    : nuevoNombre;
            }
        }

        // Evento para añadir o editar un producto
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Producto válido antes de añadir o modificar.");
                return;
            }

            string selectedName = comboBox1.SelectedItem.ToString();

            if (!comboBoxMapping.TryGetValue(selectedName, out int productID))
            {
                MessageBox.Show("El producto seleccionado no tiene un ID asignado.");
                return;
            }

            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            Form2 form2 = new Form2(productoSeleccionado.Id);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ProductoInfo nuevoProducto = form2.ProductoCreado;
                productoSeleccionado.Nombre = nuevoProducto.Nombre;
                productoSeleccionado.Precio = nuevoProducto.Precio;
                productoSeleccionado.Stock = nuevoProducto.Stock;
                productoSeleccionado.Categoria = nuevoProducto.Categoria;

                ActualizarLabelProducto(productID, productoSeleccionado.Nombre);

                MessageBox.Show($"Producto {productoSeleccionado.Nombre} actualizado correctamente.");
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }

        // Retorna el PictureBox asociado a un producto por su ID
        private PictureBox ObtenerPictureBox(int idProducto)
        {
            return idProducto switch
            {
                1 => pictureBoxProd1,
                2 => pictureBoxProd2,
                3 => pictureBoxProd3,
                4 => pictureBoxProd4,
                5 => pictureBoxProd5,
                6 => pictureBoxProd6,
                7 => pictureBoxProd7,
                8 => pictureBoxProd8,
                _ => null,
            };
        }

        // Evento para modificar un producto existente
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un producto válido a modificar.");
                return;
            }

            string selectedName = comboBox1.SelectedItem.ToString();

            if (!comboBoxMapping.TryGetValue(selectedName, out int productID))
            {
                MessageBox.Show("El producto seleccionado no tiene un ID asignado.");
                return;
            }

            ProductoInfo productoSeleccionado = productos.FirstOrDefault(p => p.Id == productID);

            if (productoSeleccionado == null || string.IsNullOrWhiteSpace(productoSeleccionado.Nombre))
            {
                MessageBox.Show("El producto no está registrado. Por favor, añádelo antes de modificar.");
                return;
            }

            Form4 formMod = new Form4(productoSeleccionado);
            if (formMod.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Producto modificado con éxito.");
            }
        }

        private void labelNomProd1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
