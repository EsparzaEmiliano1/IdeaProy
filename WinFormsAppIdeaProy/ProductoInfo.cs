using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppIdeaProy
{
    internal class ProductoInfo
    {
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; }

    public Producto(string nombre, decimal precio, int stock, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
        Categoria = categoria;
    }
    }
}
