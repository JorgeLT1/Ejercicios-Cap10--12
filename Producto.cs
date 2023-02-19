using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
}

public class Inventario
{
    private List<Producto> productos;

    public Inventario()
    {
        productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    public Producto BuscarProducto(int codigo)
    {
        return productos.Find(p => p.Codigo == codigo);
    }


}

