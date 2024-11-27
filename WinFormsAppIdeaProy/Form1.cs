using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Producto 1");
            comboBox1.Items.Add("Producto 2");
            comboBox1.Items.Add("Producto 3");
            comboBox1.Items.Add("Producto 4");
            comboBox1.Items.Add("Producto 5");
            comboBox1.Items.Add("Producto 6");
            comboBox1.Items.Add("Producto 7");
            comboBox1.Items.Add("Producto 8");
        }
        private List<ProductoInfo> productos = new List<ProductoInfo>();
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Producto antes de cargar la imagen.");
                return;
            }

            Form2 form2 = new Form2();
            string selectedBox = comboBox1.SelectedItem.ToString(); // Obtiene el producto seleccionado

            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Obtener el producto creado
                ProductoInfo nuevoProducto = form2.ProductoCreado;

                // Agregar el producto a la lista
                productos.Add(nuevoProducto);

                // Obtener el número de producto a partir del nombre seleccionado en el ComboBox
                int productoNumero = int.Parse(selectedBox.Split(' ')[1]);

                // Actualizar el nombre en el label correspondiente
                Label labelProducto = (Label)this.Controls["labelNomProd" + productoNumero];
                labelProducto.Text = nuevoProducto.Nombre; // Asignar el nombre del producto al label correspondiente
            }

            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PictureBox selectedPictureBox = null;

                // Asignar el PictureBox correspondiente según el producto seleccionado
                switch (selectedBox)
                {
                    case "Producto 1":
                        selectedPictureBox = pictureBoxProd1;
                        break;
                    case "Producto 2":
                        selectedPictureBox = pictureBoxProd2;
                        break;
                    case "Producto 3":
                        selectedPictureBox = pictureBoxProd3;
                        break;
                    case "Producto 4":
                        selectedPictureBox = pictureBoxProd4;
                        break;
                    case "Producto 5":
                        selectedPictureBox = pictureBoxProd5;
                        break;
                    case "Producto 6":
                        selectedPictureBox = pictureBoxProd6;
                        break;
                    case "Producto 7":
                        selectedPictureBox = pictureBoxProd7;
                        break;
                    case "Producto 8":
                        selectedPictureBox = pictureBoxProd8;
                        break;
                    default:
                        MessageBox.Show("No se encontró el Producto seleccionado.");
                        return;
                }

                // Asignar la imagen al PictureBox correspondiente
                string filePath = abrirImagen.FileName;
                selectedPictureBox.ImageLocation = filePath;
                selectedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Iniciar()
        {
            ticket = new DataTable();
            ticket.Columns.Add("Producto");
            ticket.Columns.Add("Categoria");
            ticket.Columns.Add("Existencia");
            ticket.Columns.Add("Precio");
            //ticket.Rows.Add("");          ///Hay que poner numeracion de cuantos productos/conjunto de productos van (?) 
            dataGridViewTicket.DataSource = ticket;

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
    }
}
