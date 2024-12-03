using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppIdeaProy
{
    public class ProductoInfo
    {
        // deberiamos crear otro atributo que sea el producto y manejar mas facil la transferencia de datos 
        // pq con el nombre puede haber errores y nada mas pasar 'Producto 1' como en el form 1 en el comboBox

    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; }

    public ProductoInfo(string nombre, decimal precio, int stock, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
        Categoria = categoria;
    }
    }
}
